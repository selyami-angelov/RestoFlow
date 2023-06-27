using RestoFlow.Core.Models.Product;

namespace RestoFlow.Core.Contracts
{
    public interface IProductService
    {
        Task<List<ProductDTO>> GetAllProducts();
        Task<ProductDTO> GetProductById(int id);
        Task<ProductDTO> CreateProduct(ProductCreateDTO productDto);
        Task<ProductDTO> UpdateProduct(int id, ProductEditDTO productDto);
        Task<ProductDTO> DeleteProduct(int id);
    }
}
