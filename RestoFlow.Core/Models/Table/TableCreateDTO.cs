using RestoFlow.Infrastructure.Data.Models;

using System.ComponentModel.DataAnnotations;

using static RestoFlow.Infrastructure.Constants.Table;

namespace RestoFlow.Core.Models.Table
{
    public class TableCreateDTO
    {

        [Required(ErrorMessage = TableNumberRequiredErrorMessage)]
        public int TableNumber { get; set; }

        [Required(ErrorMessage = TableSeatsRequiredErrorMessage)]
        public int Seats { get; set; }

    }
}
