using System.ComponentModel.DataAnnotations;

using static RestoFlow.Infrastructure.Constants.Category;

namespace RestoFlow.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = CategoryNameRequiredErrorMessage)]
        [StringLength(CategoryNameMaxLength, MinimumLength = CategoryNameMinLength,
        ErrorMessage = CategoryNameLengthErrorMessage)]
        public string Name { get; set; } = null!;

        public List<Product> Products { get; set; }

    }
}
