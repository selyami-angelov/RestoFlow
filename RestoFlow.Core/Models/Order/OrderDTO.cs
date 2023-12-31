﻿using RestoFlow.Core.Models.Product;

namespace RestoFlow.Core.Models.Order
{
    public class OrderDTO
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public ProductDTO Product { get; set; }
        public int? TableNumber { get; set; }
        public string Info { get; set; } = null!;
        public int ProductQuantity { get; set; }

        public string CreatedById { get; set; } = null!;

        public string CreatedBy { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? EditedById { get; set; }

        public string? EditedBy { get; set; }

        public DateTime? EditedDate { get; set; }

        public bool IsServed { get; set; }
        public bool IsReady { get; set; }
    }
}
