using AutoMapper;

using MockQueryable.Moq;

using Moq;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.Category;
using RestoFlow.Core.Services;
using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Tests
{
    [TestFixture]
    public class CategoryServiceTests
    {
        private Mock<IRepository> mockRepository;
        private Mock<IMapper> mockMapper;
        private CategoryService categoryService;

        [SetUp]
        public void Setup()
        {
            mockRepository = new Mock<IRepository>();
            mockMapper = new Mock<IMapper>();
            categoryService = new CategoryService(mockRepository.Object, mockMapper.Object);
        }

        [Test]
        public async Task GetAllCategories_ReturnsListOfCategoryDTOs()
        {
            // Arrange
            var dummyCategories = new List<Category>
            {
                new Category { Id = 1, Name = "Category 1", IsDeleted = false },
                new Category { Id = 2, Name = "Category 2", IsDeleted = false }
            };

            var mockCategories = dummyCategories.AsQueryable().BuildMock();

            mockRepository.Setup(repo => repo.All<Category>()).Returns(mockCategories);
            mockMapper.Setup(mapper => mapper.Map<CategoryDTO>(It.IsAny<Category>()))
                      .Returns((Category source) => new CategoryDTO
                      {
                          Id = source.Id,
                          Name = source.Name
                      });

            // Act
            var result = await categoryService.GetAllCategories();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Has.Exactly(2).Items);
            Assert.That(result, Has.Exactly(1).With.Property("Id").EqualTo(dummyCategories[0].Id));
            Assert.That(result, Has.Exactly(1).With.Property("Id").EqualTo(dummyCategories[1].Id));
            Assert.That(result, Has.Exactly(1).With.Property("Name").EqualTo(dummyCategories[0].Name));
            Assert.That(result, Has.Exactly(1).With.Property("Name").EqualTo(dummyCategories[1].Name));
        }

    }
}
