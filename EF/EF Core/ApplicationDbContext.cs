using EF_Core.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EF_Core.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=DESKTOP-8B52K43;Initial Catalog =EfLearn; Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AuditEntry>();

            new BlogEntityTypeConfiguration().Configure(modelBuilder.Entity<Blog>());
        }
        /*
            ------------Notes-------------

        -   Can Add Class To Domain Model By Another Way "Public DbSet<Blog> Blogs { get; set; }"

        - By Using [OnModelCreating] 

               protected override void OnModelCreating(ModelBuilder modelBuilder)
               {
                   modelBuilder.Entity<AuditEntry>();
               }
         



            ------------Notes-------------

        -[ExcludeFromMigrations] Table From Migrations But Still In Data Base 

         protected override void OnModelCreating(ModelBuilder modelBuilder)
               {
                   modelBuilder.Entity<AuditEntry>()    
                               .ToTable('AuditEntries',A => A.ExcludeFromMigrations());
               }
         */
        public DbSet<Blog> Blogs { get; set; }
    }
}
