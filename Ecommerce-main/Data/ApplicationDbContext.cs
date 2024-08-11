using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductOptions> ProductOptions { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Options> Options { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<ProductCategories> ProductCategories{ get; set; }
    }
}
