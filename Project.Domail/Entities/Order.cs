using Project.Domail.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Project.Domail.Entities
{
    public class Order : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public bool IsHold { get; set; }
        public bool IsCancel { get; set; }
        public string ReturnProductId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsPlaced { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsDispatched { get; set; }
        public bool IsReadyToDispatch { get; set; }
        public bool IsDelivered { get; set; }

        // Navigation properties
        //public virtual User User { get; set; }
        //public virtual Product Product { get; set; }

    }
}
