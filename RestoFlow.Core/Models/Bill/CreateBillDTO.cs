using System.ComponentModel.DataAnnotations;

namespace RestoFlow.Core.Models.Bill
{
    public class CreateBillDTO
    {
        [Required]
        public int TableId { get; set; }

    }
}
