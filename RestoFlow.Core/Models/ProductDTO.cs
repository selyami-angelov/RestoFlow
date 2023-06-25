using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static RestoFlow.Infrastructure.Constants.Product;

namespace RestoFlow.Core.Models
{
    public class ProductDTO
    {

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

        [Required]
        public string Img { get; set; } = null!;
    }
}
