using AutoMapper;

using MockQueryable.Moq;

using Moq;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.Product;
using RestoFlow.Core.Services;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Tests
{
    [TestFixture]
    public class ProductServiceTests
    {

        private Mock<IRepository> mockRepository;
        private Mock<IMapper> mockMapper;
        private ProductService productService;

        [SetUp]
        public void Setup()
        {
            mockRepository = new Mock<IRepository>();
            mockMapper = new Mock<IMapper>();
            productService = new ProductService(mockRepository.Object, mockMapper.Object);
        }

        [Test]
        public async Task GetAllProducts_ReturnsListOfProductDTOs()
        {
            // Arrange
            var mockRepository = new Mock<IRepository>();
            var mockMapper = new Mock<IMapper>();

            var productService = new ProductService(mockRepository.Object, mockMapper.Object);

            var dummyProducts = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", IsDeleted = false, Category = new Category { Id = 1, Name = "Category 1" } },
                new Product { Id = 2, Name = "Product 2", IsDeleted = false, Category = new Category { Id = 2, Name = "Category 2" } }
            };

            mockRepository.Setup(repo => repo.All<Product>()).Returns(dummyProducts.AsQueryable());

            mockMapper.Setup(m => m.Map<ProductDTO>(It.IsAny<Product>()))
                      .Returns((Product source) => new ProductDTO
                      {
                          Id = source.Id,
                          Name = source.Name,
                          CategoryName = source.Category.Name,
                          CategoryId = source.Category.Id,
                      });

            // Act
            var result = await productService.GetAllProducts();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Has.Exactly(2).Items);
            Assert.That(result, Has.Exactly(1).With.Property("Id").EqualTo(dummyProducts[0].Id));
            Assert.That(result, Has.Exactly(1).With.Property("Id").EqualTo(dummyProducts[1].Id));
            Assert.That(result, Has.Exactly(1).With.Property("Name").EqualTo(dummyProducts[0].Name));
            Assert.That(result, Has.Exactly(1).With.Property("Name").EqualTo(dummyProducts[1].Name));
            Assert.That(result, Has.Exactly(1).With.Property("CategoryId").EqualTo(dummyProducts[0].Category.Id));
            Assert.That(result, Has.Exactly(1).With.Property("CategoryId").EqualTo(dummyProducts[1].Category.Id));
            Assert.That(result, Has.Exactly(1).With.Property("CategoryName").EqualTo(dummyProducts[0].Category.Name));
            Assert.That(result, Has.Exactly(1).With.Property("CategoryName").EqualTo(dummyProducts[1].Category.Name));

        }

        [Test]
        public async Task GetProductById_ReturnsNull_WhenProductIsDeleted()
        {
            // Arrange
            var productId = 1;
            var dummyProduct = new Product { Id = productId, Name = "Product 1", IsDeleted = true, Category = new Category { Id = 1, Name = "Category 1" } };

            var mockProducts = new List<Product> { dummyProduct }.AsQueryable().BuildMock();
            mockRepository.Setup(repo => repo.All<Product>()).Returns(mockProducts);

            // Act
            var result = await productService.GetProductById(productId);

            // Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task GetProductById_ReturnsProductDTO_WhenProductExists()
        {
            // Arrange
            var productId = 1;
            var categoryName = "Category 1";
            var dummyCategory = new Category { Id = 1, Name = categoryName };
            var dummyProduct = new Product { Id = productId, Name = "Product 1", IsDeleted = false, Category = dummyCategory };

            var asyncEnumerable = new List<Product> { dummyProduct }.AsQueryable().BuildMock();
            mockRepository.Setup(repo => repo.All<Product>()).Returns(asyncEnumerable);

            mockMapper.Setup(m => m.Map<ProductDTO>(It.IsAny<Product>())).Returns((Product source) => new ProductDTO { Id = source.Id });

            // Act
            var result = await productService.GetProductById(productId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(productId));
            Assert.That(result.CategoryName, Is.EqualTo(categoryName));
        }

        [Test]
        public async Task GetProductByIds_ReturnsListOfProductDTOs()
        {
            // Arrange
            var productIds = new[] { 1, 2 };
            var dummyProducts = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", IsDeleted = false, Category = new Category { Id = 1, Name = "Category 1" } },
                new Product { Id = 2, Name = "Product 2", IsDeleted = false, Category = new Category { Id = 2, Name = "Category 2" } }
            };
            mockRepository.Setup(repo => repo.All<Product>()).Returns(dummyProducts.AsQueryable());
            mockMapper.Setup(m => m.Map<ProductDTO>(It.IsAny<Product>())).Returns((Product source) => new ProductDTO { Id = source.Id });

            // Act
            var result = await productService.GetProductByIds(productIds);

            // Assert
            Assert.That(result, Has.Exactly(2).Items);
            Assert.That(result.Select(p => p.Id), Is.EquivalentTo(productIds));
        }

        [Test]
        public async Task CreateProduct_ReturnsCreatedProductDTO()
        {
            // Arrange
            var productDto = new ProductCreateDTO { };
            var objectUrl = "sample-url";
            var createdProduct = new Product { };
            mockMapper.Setup(m => m.Map<Product>(It.IsAny<ProductCreateDTO>())).Returns(createdProduct);
            mockRepository.Setup(repo => repo.AddAsync<Product>(It.IsAny<Product>())).Verifiable();
            mockRepository.Setup(repo => repo.SaveChangesAsync()).Verifiable();
            mockMapper.Setup(m => m.Map<ProductDTO>(It.IsAny<Product>())).Returns((Product source) => new ProductDTO { Id = source.Id });

            // Act
            var result = await productService.CreateProduct(productDto, objectUrl);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(createdProduct.Id));
        }

        [Test]
        public async Task UpdateProduct_ReturnsUpdatedProductDTO_WhenProductExists()
        {
            // Arrange
            var productId = 1;
            var productDto = new ProductEditDTO { };
            var objectUrl = "updated-sample-url";
            var existingProduct = new Product { Id = productId, Name = "Product 1", IsDeleted = false, Category = new Category { Id = 1, Name = "Category 1" } };
            mockRepository.Setup(repo => repo.All<Product>()).Returns(new List<Product> { existingProduct }.AsQueryable().BuildMock());
            mockMapper.Setup(m => m.Map<Product>(It.IsAny<ProductEditDTO>())).Returns(existingProduct);
            mockRepository.Setup(repo => repo.Update<Product>(It.IsAny<Product>())).Verifiable();
            mockRepository.Setup(repo => repo.SaveChangesAsync()).Verifiable();
            mockMapper.Setup(m => m.Map<ProductDTO>(It.IsAny<Product>())).Returns((Product source) => new ProductDTO { Id = source.Id });

            // Act
            var result = await productService.UpdateProduct(productId, productDto, objectUrl);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(existingProduct.Id));
        }

        [Test]
        public async Task UpdateProduct_ReturnsNull_WhenProductNotFoundOrDeleted()
        {
            // Arrange
            var productId = 1;
            var productDto = new ProductEditDTO { };
            var objectUrl = "updated-sample-url";
            var nonExistingProduct = new Product { Id = productId, IsDeleted = true };
            mockRepository.Setup(repo => repo.All<Product>()).Returns(new List<Product> { nonExistingProduct }.AsQueryable().BuildMock());

            // Act
            var result = await productService.UpdateProduct(productId, productDto, objectUrl);

            // Assert
            Assert.That(result, Is.Null);
        }

        [Test]
        public async Task DeleteProduct_ReturnsDeletedProductDTO_WhenProductExists()
        {
            // Arrange
            var productId = 1;
            var existingProduct = new Product { Id = productId, Name = "Product 1", IsDeleted = false, Category = new Category { Id = 1, Name = "Category 1" } };
            mockRepository.Setup(repo => repo.GetByIdAsync<Product>(It.IsAny<int>())).ReturnsAsync(existingProduct);
            mockRepository.Setup(repo => repo.SaveChangesAsync()).Verifiable();
            mockMapper.Setup(m => m.Map<ProductDTO>(It.IsAny<Product>())).Returns((Product source) => new ProductDTO { Id = source.Id });

            // Act
            var result = await productService.DeleteProduct(productId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(existingProduct.Id));
            Assert.That(existingProduct.IsDeleted, Is.True);
        }
    }
}
