using Microsoft.EntityFrameworkCore;

using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Infrastructure.Configuration
{
    public static class FluenAPI
    {
        public static void ConfigureTables(ModelBuilder modelBuilder)
        {
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
        }

        public static void ConfigureProducts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
               .HasOne(p => p.Category)
               .WithMany(c => c.Products)
               .HasForeignKey(p => p.CategoryId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
