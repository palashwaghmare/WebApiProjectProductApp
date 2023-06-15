

using Microsoft.EntityFrameworkCore;

namespace WebApiProject.AppDbContext
{
    public class AppsDbContext: DbContext
    {
        public AppsDbContext(DbContextOptions<AppsDbContext> Context):base(Context)
        {
            
        }

        public DbSet<Bookings> Bookings { get; set; }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasMany(u => u.bookings)
                .WithOne(b => b.Products)
                .HasForeignKey(b => b.ProductId);

        }



    }
}
