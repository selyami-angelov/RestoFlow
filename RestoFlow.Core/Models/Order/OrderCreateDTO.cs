using System.ComponentModel.DataAnnotations;

using static RestoFlow.Infrastructure.Constants.Order;

namespace RestoFlow.Core.Models.Order
{
    public class OrderCreateDTO
    {

        [Required]
        public int ProductId { get; set; }

        [StringLength(OrderInfoMaxLength, MinimumLength = OrderInfoMinLength,
            ErrorMessage = OrderInfoLengthErrorMessage)]
        public string? Info { get; set; }

        [Range(OrderProductQuantityMinLength, OrderProductQuantityMaxLength, ErrorMessage = OrderProductQuantityLengthErrorMessage)]
        public int ProductQuantity { get; set; }

    }
}
