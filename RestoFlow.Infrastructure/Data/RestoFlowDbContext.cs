using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Infrastructure.Data
{
    public class RestoFlowDbContext : IdentityDbContext<ApplicationUser>
    {
        public RestoFlowDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OccupiedTable>()
                .HasKey(ot => new { ot.TableId, ot.UserId, ot.OrderId });

            modelBuilder.Entity<OccupiedTable>()
                .HasOne(ot => ot.Table)
                .WithMany()
                .HasForeignKey(ot => ot.TableId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OccupiedTable>()
                .HasOne(ot => ot.User)
                .WithMany()
                .HasForeignKey(ot => ot.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OccupiedTable>()
                .HasOne(ot => ot.Order)
                .WithMany()
                .HasForeignKey(ot => ot.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            DbSeeder.SeedCategories(modelBuilder);
            DbSeeder.SeedProducts(modelBuilder);

        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<OccupiedTable> OccupiedTables { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Table> Tables { get; set; }
    }
}
