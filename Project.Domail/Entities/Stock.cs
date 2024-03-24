
using Project.Domail.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Project.Domail.Entities
{
    public class Stock : BaseEntity
    {
        public Guid ProductId { get; set; }
        public Guid TraderId { get; set; }
        public Guid Quantity { get; set; }
        public bool IsQC { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }

        // Navigation properties
        //public virtual Product Product { get; set; }
        //public virtual Trader Trader { get; set; }

    }
}
