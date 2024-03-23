using Project.Domail.Entities.Base;

namespace Project.Domail.Entities
{
    public class ProductSize : BaseEntity
    {
        public decimal Size { get; set; }
        public string ? Unit { get; set; }
        public string ? CreatedBy { get; set; }
        public string ? UpdatedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
