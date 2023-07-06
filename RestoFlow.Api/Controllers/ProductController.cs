using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.AwsS3;
using RestoFlow.Core.Models.Product;

using System.Text.Json;

namespace RestoFlow.Api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IStorageService storageService;
        private readonly IConfiguration configuration;

        public object JsonConvert { get; private set; }

        public ProductController(IProductService _productService, IStorageService _storageService, IConfiguration _configuration)
        {
            productService = _productService;
            storageService = _storageService;
            configuration = _configuration;
        }

        /// <summary>
        /// Retrieves all products.
        /// </summary>
        /// <returns>A list of products.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await productService.GetAllProducts();
            return Ok(products);
        }

        /// <summary>
        /// Retrieves a product by its ID.
        /// </summary>
        /// <param name="id">The ID of the product.</param>
        /// <returns>The product with the specified ID.</returns>
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

        /// <summary>
        /// Retrieves range of products by IDs.
        /// </summary>
        /// <returns>A list of products.</returns>
        [HttpGet("range")]
        public async Task<IActionResult> GetProdctsByIds([FromQuery(Name = "ids")] string ids)
        {
            var productIds = ids.Split(',')
                       .Select(int.Parse)
                       .ToArray();
            var products = await productService.GetProductByIds(productIds);
            return Ok(products);
        }

        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <param name="productDto">The product data.</param>
        /// <returns>The created product.</returns>
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromForm] ProductCreateDTO productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await using var memoryStream = new MemoryStream();
            await productDto.File.CopyToAsync(memoryStream);

            var fileExtension = Path.GetExtension(productDto.File.FileName);
            var objName = $"{Guid.NewGuid()}.{fileExtension}";

            var s3Obj = new S3Object()
            {
                BucketName = "resto-flow",
                InputStream = memoryStream,
                Name = objName
            };

            var cred = new AwsCredentials()
            {
                AwsKey = configuration["AwsConfiguration:AWSAccessKey"],
                AwsSecretKey = configuration["AwsConfiguration:AWSSecretKey"]
            };

            var result = await storageService.UploadFileAsync(s3Obj, cred);
            return Ok(result);
            //var createdProduct = await productService.CreateProduct(productDto);
            //return CreatedAtAction(nameof(GetProductById), new { id = createdProduct.Id }, createdProduct);
        }

        /// <summary>
        /// Updates an existing product.
        /// </summary>
        /// <param name="id">The ID of the product to update.</param>
        /// <param name="productDto">The updated product data.</param>
        /// <returns>The updated product.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, ProductEditDTO productDto)
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

        /// <summary>
        /// Deletes a product.
        /// </summary>
        /// <param name="id">The ID of the product to delete.</param>
        /// <returns>The deleted product.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var deletedProduct = await productService.DeleteProduct(id);
            if (deletedProduct == null)
            {
                return NotFound();
            }

            return Ok(deletedProduct);
        }
    }
}
