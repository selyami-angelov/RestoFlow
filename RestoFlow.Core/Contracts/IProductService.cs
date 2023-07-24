using RestoFlow.Core.Models.Product;

namespace RestoFlow.Core.Contracts
{
    public interface IProductService
    {
        Task<List<ProductDTO>> GetAllProducts();
        Task<ProductDTO> GetProductById(int id);
        Task<ProductDTO> CreateProduct(ProductCreateDTO productDto,string objectUrl);
        Task<ProductDTO> UpdateProduct(int id, ProductEditDTO productDto, string? objectUrl);
        Task<ProductDTO> DeleteProduct(int id);

        Task<List<ProductDTO>> GetProductByIds(int[] ids);
    }
}
