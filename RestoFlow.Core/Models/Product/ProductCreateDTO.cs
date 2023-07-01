using System.ComponentModel.DataAnnotations;

using static RestoFlow.Infrastructure.Constants.Product;


namespace RestoFlow.Core.Models.Product
{
    public class ProductCreateDTO
    {
        [Required(ErrorMessage = ProductNameRequiredErrorMessage)]
        [StringLength(ProductNameMaxLength, MinimumLength = ProductNameMinLength,
            ErrorMessage = ProductNameLengthErrorMessage)]
        public string Name { get; set; } = null!;


        [Required(ErrorMessage = ProductDescriptionRequiredErrorMessage)]
        [StringLength(ProductDescriptionMaxLength,
            MinimumLength = ProductDescriptionMinLength,
            ErrorMessage = ProductDescriptionLengthErrorMessage)]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = ProductPriceRequireErrorMessage)]
        [Range(ProductPriceMinValue, ProductPriceMinValue, ErrorMessage = ProductPriceRangeErrorMessage)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = ProductCategoryIdRequiredErrorMessage)]
        public int CategoryId { get; set; }

        [Required]
        public string Img { get; set; } = null!;
    }
}
