using RestoFlow.Core.Models;

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
        Task<ProductDTO> CreateProduct(ProductDTO productDto);
        Task<ProductDTO> UpdateProduct(int id, ProductDTO productDto);
        Task<ProductDTO> DeleteProduct(int id);
    }
}
