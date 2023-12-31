﻿using RestoFlow.Core.Models.Order;

namespace RestoFlow.Core.Models.Bill
{
    public class BillDTO
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public int TableNumber { get; set; }
        public string UserId { get; set; }
        public DateTime Date { get; set; }
        public int ProductQuantity { get; set; }
        public List<OrderDTO> Orders { get; set; }
        public string? User { get; set; }
        public decimal TotalSum { get; set; }
    }
}
