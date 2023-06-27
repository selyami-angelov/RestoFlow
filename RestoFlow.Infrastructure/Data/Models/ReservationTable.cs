using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoFlow.Infrastructure.Data.Models
{
    public class ReservationTable
    {
        public int ReservationId { get; set; }
        [ForeignKey(nameof(ReservationId))]
        public Reservation Reservation { get; set; } = null!;

        public int TableId { get; set; }
        [ForeignKey(nameof(TableId))]
        public Table Table { get; set; } = null!;
    }
}
