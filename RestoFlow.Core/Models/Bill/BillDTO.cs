using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoFlow.Core.Models.Bill
{
    public class BillDTO
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public string UserId { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalSum { get; set; }
    }
}
