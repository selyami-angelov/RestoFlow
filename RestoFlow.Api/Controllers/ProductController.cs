using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using RestoFlow.Core.Models;

namespace RestoFlow.Api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductDTO productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdProduct = await productService.CreateProduct(productDto);
            return CreatedAtAction(nameof(GetProductById), new { id = createdProduct.Id }, createdProduct);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, ProductDTO productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedProduct = await productService.UpdateProduct(id, productDto);
            if (updatedProduct == null)
            {
                return NotFound();
            }

            return Ok(updatedProduct);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var deletedProduct = await productService.DeleteProduct(id);
            if (deletedProduct == null)
            {
                return NotFound();
            }

            return NoContent();
       }
    }
}
