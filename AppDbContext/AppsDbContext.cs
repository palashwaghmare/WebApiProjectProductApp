

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApiProject.AppDbContext.Configurations;

namespace WebApiProject.AppDbContext
{
    public class AppsDbContext: IdentityDbContext<APIUser>
    {
        public AppsDbContext(DbContextOptions<AppsDbContext> Context):base(Context)
        {
            
        }

        public DbSet<Bookings> Bookings { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<APIUser> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RolesConfiguration());

            modelBuilder.Entity<Product>()
                .HasMany(p => p.bookings)
                .WithOne(b => b.Products)
                .HasForeignKey(b => b.ProductId);

            
        }



    }
}
