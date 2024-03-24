using Project.Domail.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace Project.Domail.Entities
{
    public class ProdReturn : BaseEntity
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string ProdSizeId { get; set; }
        public string ProdValveId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        // Navigation property
        //public virtual Product Product { get; set; }

    }
}
