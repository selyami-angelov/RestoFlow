using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static RestoFlow.Infrastructure.Constants.Product;

namespace RestoFlow.Infrastructure.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = ProductNameRequiredErrorMessage)]
        [StringLength(ProductNameMaxLength, MinimumLength = ProductNameMinLength,
            ErrorMessage = ProductNameLengthErrorMessage)]
        public string Name { get; set; } = null!;


        [Required(ErrorMessage = ProductDescriptionRequiredErrorMessage)]
        [StringLength(ProductDescriptionMaxLength,
            MinimumLength = ProductDescriptionMinLength,
            ErrorMessage = ProductDescriptionLengthErrorMessage)]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = ProductCategoryIdRequiredErrorMessage)]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        public string Img { get; set; } = null!;
    }
}

