using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using RestoFlow.Core.Contracts;
using RestoFlow.Core.Models.AwsS3;
using RestoFlow.Core.Models.Product;

namespace RestoFlow.Api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IStorageService storageService;
        private readonly IConfiguration configuration;
        private readonly IAwsCredentialsService awsCredentialsService;
        bool isLocalHost = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";

        public object JsonConvert { get; private set; }

        public ProductController(IProductService _productService, IStorageService _storageService, IConfiguration _configuration, IAwsCredentialsService _awsCredentialsService)
        {
            productService = _productService;
            storageService = _storageService;
            configuration = _configuration;
            awsCredentialsService = _awsCredentialsService;
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
        [Authorize(Policy = "AdminOrWaiterPolicy")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            var s3Obj = new S3ObjectCreateDTO()
            {
                BucketName = "resto-flow",
                Name = product.Img,
            };

            var cred = isLocalHost ? awsCredentialsService.GetAwsCredentialsFromEnvironment() : awsCredentialsService.GetAwsCredentialsFromAppSettings();

            var result = storageService.GeneratePresignedUrl(s3Obj, cred);
            product.Img = result.Result;

            return Ok(product);
        }

        /// <summary>
        /// Retrieves range of products by IDs.
        /// </summary>
        /// <returns>A list of products.</returns>
        [HttpGet("range")]
        [Authorize(Policy = "AdminOrWaiterPolicy")]
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
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateProduct([FromForm] ProductCreateDTO productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            await using var memoryStream = new MemoryStream();
            await productDto.File.CopyToAsync(memoryStream);

            var fileExtension = Path.GetExtension(productDto.File.FileName);
            var objName = $"{Guid.NewGuid()}{fileExtension}";

            var s3Obj = new S3ObjectCreateDTO()
            {
                BucketName = "resto-flow",
                InputStream = memoryStream,
                Name = objName
            };

            var cred = isLocalHost ? awsCredentialsService.GetAwsCredentialsFromEnvironment() : awsCredentialsService.GetAwsCredentialsFromAppSettings();

            var result = await storageService.UploadFileAsync(s3Obj, cred);

            if (result.StatusCode == 200)
            {
                string objectUrl = $"https://{s3Obj.BucketName}.s3.eu-central-1.amazonaws.com/{objName}";
                var createdProduct = await productService.CreateProduct(productDto, objectUrl);
                return CreatedAtAction(nameof(GetProductById), new { id = createdProduct.Id }, createdProduct);
            }
            else
            {
                return StatusCode(result.StatusCode, result.Message);
            }

            return Ok(result);
        }

        /// <summary>
        /// Updates an existing product.
        /// </summary>
        /// <param name="id">The ID of the product to update.</param>
        /// <param name="productDto">The updated product data.</param>
        /// <returns>The updated product.</returns>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateProduct(int id, [FromForm] ProductEditDTO productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var objName = "";
            var existingProduct = await productService.GetProductById(id);

            // Check if a new file was uploaded
            if (productDto.File != null)
            {
                await using var memoryStream = new MemoryStream();
                await productDto.File.CopyToAsync(memoryStream);

                var fileExtension = Path.GetExtension(productDto.File.FileName);
                objName = $"{Guid.NewGuid()}{fileExtension}";

                var s3Obj = new S3ObjectCreateDTO()
                {
                    BucketName = "resto-flow",
                    InputStream = memoryStream,
                    Name = objName
                };

                var cred = isLocalHost ? awsCredentialsService.GetAwsCredentialsFromEnvironment() : awsCredentialsService.GetAwsCredentialsFromAppSettings();

                var result = await storageService.UploadFileAsync(s3Obj, cred);

                if (result.StatusCode == 200)
                {

                    if (!string.IsNullOrEmpty(existingProduct.Img))
                    {
                        string objectKey = existingProduct.Img.TrimStart('/');
                        var deleteResult = await storageService.DeleteFileAsync(objectKey, "resto-flow", cred);
                        if (deleteResult.StatusCode != 200)
                        {
                            return StatusCode(deleteResult.StatusCode, deleteResult.Message);
                        }
                    }

                }
                else
                {
                    return StatusCode(result.StatusCode, result.Message);
                }
            }

            // Update the product in the database
            string objectUrl = productDto.File == null ? existingProduct.Img : $"https://resto-flow.s3.eu-central-1.amazonaws.com/{objName}";
            await productService.UpdateProduct(id, productDto, objectUrl);

            return Ok(existingProduct);
        }

        /// <summary>
        /// Deletes a product.
        /// </summary>
        /// <param name="id">The ID of the product to delete.</param>
        /// <returns>The deleted product.</returns>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
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
