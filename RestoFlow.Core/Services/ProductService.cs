
using AutoMapper;

using Microsoft.EntityFrameworkCore;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.Product;
using RestoFlow.Infrastructure.Data.Models;


namespace RestoFlow.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repository;
        private readonly IMapper mapper;

        public ProductService(IRepository _repository, IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;
        }

        public async Task<List<ProductDTO>> GetAllProducts()
        {
            var products = repository.All<Product>().Where(p => !p.IsDeleted);
            return products.Select(product => mapper.Map<ProductDTO>(product)).ToList();
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            var product = await repository.All<Product>().Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);

            if (product.IsDeleted)
            {
                return null;
            }
            var result = mapper.Map<ProductDTO>(product);
            result.CategoryName = product.Category.Name;
            return result;
        }

        public async Task<List<ProductDTO>> GetProductByIds(int[] ids)
        {
            var products =  repository.All<Product>().Where(p => ids.Any(id => id == p.Id) && !p.IsDeleted).ToList();
            return products.Select(product => mapper.Map<ProductDTO>(product)).ToList();
        }

        public async Task<ProductDTO> CreateProduct(ProductCreateDTO productDto)
        {
            var product = mapper.Map<Product>(productDto);
            await repository.AddAsync<Product>(product);
            await repository.SaveChangesAsync();
            var createdProductDto = mapper.Map<ProductDTO>(product);
            return createdProductDto;
        }

        public async Task<ProductDTO> UpdateProduct(int id, ProductEditDTO productDto)
        {
            var existingProduct = await repository.All<Product>().Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
            if (existingProduct == null || existingProduct.IsDeleted)
            {
                return null;
            }

            mapper.Map(productDto, existingProduct);
            repository.Update<Product>(existingProduct);
            await repository.SaveChangesAsync();
            var result = mapper.Map<ProductDTO>(existingProduct);
            result.CategoryName = existingProduct.Category.Name;
            return result;
        }

        public async Task<ProductDTO> DeleteProduct(int id)
        {
            var existingProduct = await repository.GetByIdAsync<Product>(id);
            if (existingProduct == null)
            {
                return null;
            }

            existingProduct.IsDeleted = true;
            await repository.SaveChangesAsync();
            return mapper.Map<ProductDTO>(existingProduct);
        }

    }
}
