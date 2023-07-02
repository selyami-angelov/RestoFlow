using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static RestoFlow.Infrastructure.Constants;

namespace RestoFlow.Infrastructure.Data.Models
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int TableId { get; set; }

        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        public DateTime Date { get; set; }

        [Range(0, double.MaxValue)]
        public decimal TotalSum { get; set; }

        [ForeignKey(nameof(TableId))]
        public Table Table { get; set; } = null!;

        [ForeignKey(nameof(UserId))]

        public ApplicationUser User { get; set; } = null!;

        public List<Order> Orders { get; set; } = null!;
    }
}
