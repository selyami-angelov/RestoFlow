using System.ComponentModel.DataAnnotations;

using static RestoFlow.Infrastructure.Constants.Table;

namespace RestoFlow.Infrastructure.Data.Models
{
    public class Table
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = TableNumberRequiredErrorMessage)]
        public int TableNumber { get; set; }

        [Required(ErrorMessage = TableSeatsRequiredErrorMessage)]
        public int Seats { get; set; }         
    }
}
