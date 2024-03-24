﻿using Project.Domail.Entities.Base;

namespace Project.Domail.Entities
{
    public class Product : BaseEntity
    {

        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public Guid ProdSizeId { get; set; }
        public Guid ProdValveId { get; set; }
        public string ProdImage { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }

        // Navigation properties
        //public virtual Company Company { get; set; }
        //public virtual ProductSize Size { get; set; }
        //public virtual Valve Valve { get; set; }
        //public virtual ICollection<Order> Orders { get; set; }
        //public virtual ICollection<ProdReturn> Returns { get; set; }

    }
}
