
using AutoMapper;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models;
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
        }

        public async Task<List<ProductDTO>> GetAllProducts()
        {
            var products = repository.All<Product>().ToList();
            return products.Select(product => mapper.Map<ProductDTO>(product)).ToList();
        }

        public async Task<ProductDTO> GetProductById(int id)
        {
            var product = await repository.GetByIdAsync<Product>(id);
            return mapper.Map<ProductDTO>(product);
        }

        public async Task<ProductDTO> CreateProduct(ProductDTO productDto)
        {
            var product = mapper.Map<Product>(productDto);
            await repository.AddAsync<Product>(product);
            await repository.SaveChangesAsync();
            return productDto;
        }

        public async Task<ProductDTO> UpdateProduct(int id, ProductDTO productDto)
        {
            var existingProduct = await repository.GetByIdAsync<Product>(id);
            if (existingProduct == null)
            {
                return null;
            }

            existingProduct.Name = productDto.Name;
            existingProduct.Description = productDto.Description;
            existingProduct.CategoryId = productDto.CategoryId;
            existingProduct.Img = productDto.Img;

            repository.Update<Product>(existingProduct);
            await repository.SaveChangesAsync();

            return mapper.Map<ProductDTO>(existingProduct);
        }

        public async Task<ProductDTO> DeleteProduct(int id)
        {
            var existingProduct = await repository.GetByIdAsync<Product>(id);
            if (existingProduct == null)
            {
                return null;
            }

            await repository.DeleteAsync<Product>(existingProduct);
            await repository.SaveChangesAsync();

            return mapper.Map<ProductDTO>(existingProduct);
        }
    }
}
