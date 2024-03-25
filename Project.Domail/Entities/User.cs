﻿using Project.Domail.Entities.Base;


namespace Project.Domail.Entities
{
    public class User : BaseEntity
    {
        public string? Name { get; set; }
        public string? EmailAddress { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DeactivatedDate { get; set; }
        public string? DeactiveBy { get; set; }
        public string? TIN { get; set; }
        public bool? IsBlocked { get; set; }

        // Navigation properties
        public virtual ICollection<DeliveryAddress>? DeliveryAddresses { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }

    }
}
