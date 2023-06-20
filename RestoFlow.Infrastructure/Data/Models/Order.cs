using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static RestoFlow.Infrastructure.Constants.Order;
namespace RestoFlow.Infrastructure.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; } = null!;

        [Required(ErrorMessage = ProductInfoRequiredErrorMessage)]
        [StringLength(ProductInfoMaxLength, MinimumLength = ProductInfoMinLength,
            ErrorMessage = ProductInfoLengthErrorMessage)]
        public string Info { get; set; } = null!;

        [Required]
        public string CreatedById { get; set; } = null!;

        [ForeignKey(nameof(CreatedById))]
        public ApplicationUser CreatedBy { get; set; } = null!;

        [Required]
        public DateTime CreatedDate { get; set; }

        public string? EditedById { get; set; }

        [ForeignKey(nameof(EditedById))]
        public ApplicationUser? EditedBy { get; set; }

        public DateTime? EditedDate { get; set; }

        [Required]
        public bool IsServed { get; set; }

    }
}
