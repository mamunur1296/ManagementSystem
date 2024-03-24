using Microsoft.EntityFrameworkCore;
using Project.Domail.Entities;

namespace Project.Infrastructure.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<ProductSize>? productSizes { get; set; }
        public DbSet<Retailer> ? railers { get; set; }
        public DbSet<Company> ? companies { get; set; }
        public DbSet<DeliveryAddress>? deliveryAddresses { get; set;}
        public DbSet<Order> ? orders { get; set; }
        public DbSet<ProdReturn>? prodReturns { get; set; }
        public DbSet<Product> ? products { get; set; }
        public DbSet<Stock> ? stacks {  get; set; }
        public DbSet<Trader> ? traders { get; set; }
        public DbSet<User> ? users { get; set; }
    }
}
