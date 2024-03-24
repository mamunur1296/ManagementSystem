﻿

namespace Project.Application.DTOs
{
    public class StockDTO
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid TraderId { get; set; }
        public Guid Quantity { get; set; }
        public bool IsQC { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
