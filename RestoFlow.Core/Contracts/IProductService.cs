using RestoFlow.Core.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
