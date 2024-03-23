using System.ComponentModel.DataAnnotations;
namespace Project.Domail.Entities
{
    


    //public class Company
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Contactperson { get; set; }
    //    public string ContactPerNum { get; set; }
    //    public string ContactNumber { get; set; }
    //    public string CreatedBy { get; set; }
    //    public DateTime? CreationDate { get; set; }
    //    public string UpdatedBy { get; set; }
    //    public DateTime? UpdateDate { get; set; }
    //    public bool? IsActive { get; set; }
    //    public DateTime? DeactivatedDate { get; set; }
    //    public string DeactiveBy { get; set; }
    //    public string BIN { get; set; }

    //    // Navigation properties
    //    //public virtual ICollection<Product> Products { get; set; }
    //    //public virtual ICollection<Trader> Traders { get; set; }
    //}

    //public class DeliveryAddress
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public int UserId { get; set; }
    //    public string Address { get; set; }
    //    public string Phone { get; set; }
    //    public string Mobile { get; set; }
    //    public string CreatedBy { get; set; }
    //    public DateTime? CreationDate { get; set; }
    //    public string UpdatedBy { get; set; }
    //    public DateTime? UpdateDate { get; set; }
    //    public bool? IsActive { get; set; }
    //    public DateTime? DeactivatedDate { get; set; }
    //    public string DeactiveBy { get; set; }
    //    public bool? IsDefault { get; set; }

    //    // Navigation property
    //    public virtual User User { get; set; }
    //}

    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public bool IsHold { get; set; }
        public bool IsCancel { get; set; }
        public string ReturnProductId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsPlaced { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsDispatched { get; set; }
        public bool IsReadyToDispatch { get; set; }
        public bool IsDelivered { get; set; }

        // Navigation properties
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }

    public class ProdReturn
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProdSizeId { get; set; }
        public string ProdValveId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }

        // Navigation property
        public virtual Product Product { get; set; }
    }

    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public int ProdSizeId { get; set; }
        public int ProdValveId { get; set; }
        public string ProdImage { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }

        // Navigation properties
        public virtual Company Company { get; set; }
        public virtual ProductSize Size { get; set; }
        public virtual Valve Valve { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        //public virtual ICollection<ProdReturn> Returns { get; set; }
    }

    //public class ProductSize
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public decimal Size { get; set; }
    //    public string Unit { get; set; }
    //    public string CreatedBy { get; set; }
    //    public DateTime CreationDate { get; set; }
    //    public string UpdatedBy { get; set; }
    //    public DateTime? UpdateDate { get; set; }
    //    public bool IsActive { get; set; }
    //}

    //public class Retailer
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Contactperson { get; set; }
    //    public string ContactPerNum { get; set; }
    //    public string ContactNumber { get; set; }
    //    public string CreatedBy { get; set; }
    //    public DateTime CreationDate { get; set; }
    //    public string UpdatedBy { get; set; }
    //    public DateTime? UpdateDate { get; set; }
    //    public bool IsActive { get; set; }
    //    public DateTime? DeactivatedDate { get; set; }
    //    public string DeactiveBy { get; set; }
    //    public string BIN { get; set; }
    //}

    public class Stock
    {
        [Key]
        public string Id { get; set; }
        public string ProductId { get; set; }
        public string TraderId { get; set; }
        public int Quantity { get; set; }
        public bool IsQC { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }

        // Navigation properties
        public virtual Product Product { get; set; }
        public virtual Trader Trader { get; set; }
    }

    public class Trader
    {
        [Key]
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Contactperson { get; set; }
        public string ContactPerNum { get; set; }
        public string ContactNumber { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DeactivatedDate { get; set; }
        public string DeactiveBy { get; set; }
        public string BIN { get; set; }

        // Navigation properties
        //public virtual ICollection<Stock> Stocks { get; set; }
    }

    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? DeactivatedDate { get; set; }
        public string DeactiveBy { get; set; }
        public string TIN { get; set; }
        public bool? IsBlocked { get; set; }

        // Navigation properties
        //public virtual ICollection<DeliveryAddress> DeliveryAddresses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }

    public class Valve
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
        public string Unit { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }


}
