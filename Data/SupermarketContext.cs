using Microsoft.EntityFrameworkCore;
using SupermarketWeb.Models;

namespace SupermarketWeb.Data
{
    public class SupermarketContext : DbContext
    {
        public SupermarketContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<Provider> Providers {  get; set; } 

        public DbSet<Category> Categories { get; set; }
        public DbSet<SupermarketWeb.Models.PayMode> PayMode { get; set; } = default!;


        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb\\mssqllocaldb;Database=SupermarketEF;Trusted_Connection=True;");
        }*/

    }
}
