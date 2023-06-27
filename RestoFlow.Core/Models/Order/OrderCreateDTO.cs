using RestoFlow.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestoFlow.Core.Models.Order
{
    public class OrderCreateDTO
    {

        [Required]
        public int ProductId { get; set; }

        public string? Info { get; set; } 

    }
}
