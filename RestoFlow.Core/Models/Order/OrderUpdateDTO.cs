using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoFlow.Core.Models.Order
{
    public class OrderUpdateDTO
    {
        public int ProductId { get; set; }

        public string? Info { get; set; }

        public bool IsServed { get; set; }
        public bool IsReady { get; set; }
    }
}
