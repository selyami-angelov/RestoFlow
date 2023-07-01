using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using RestoFlow.Infrastructure.Data.Models;

namespace RestoFlow.Infrastructure.Configuration
{
    public static class FluenAPI
    {
        public static void ConfigureOccupiedTables(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OccupiedTable>()
              .HasKey(ot => new { ot.TableId, ot.UserId, ot.OrderId });

            modelBuilder.Entity<OccupiedTable>()
                .HasOne(ot => ot.Table)
                .WithMany(t => t.OccupiedTables)
                .HasForeignKey(ot => ot.TableId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OccupiedTable>()
                .HasOne(ot => ot.User)
                .WithMany(u=> u.OccupiedTables)
                .HasForeignKey(ot => ot.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OccupiedTable>()
                .HasOne(ot => ot.Order)
                .WithMany(o => o.OccupiedTables)
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

            modelBuilder.Entity<Product>()
               .Property(p => p.Price)
               .HasPrecision(18, 2);
        }

        public static void ConfigureOrders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
               .HasMany(o => o.OccupiedTables)
               .WithOne(ot => ot.Order)
               .OnDelete(DeleteBehavior.Restrict);
        }

        public static void ConfigureReservations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReservationTable>()
                .HasKey(rt => new { rt.TableId, rt.ReservationId });

            modelBuilder.Entity<ReservationTable>()
                .HasOne(rt => rt.Reservation)
                .WithMany(r => r.ReservationTables)
                .HasForeignKey(rt => rt.ReservationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ReservationTable>()
                .HasOne(rt => rt.Table)
                .WithMany(t => t.ReservationTables)
                .HasForeignKey(rt => rt.TableId)
                .OnDelete(DeleteBehavior.Restrict);

        }


        public static void ConfigurePrice(ModelBuilder modelBuilder)
        {

           

        }

    }
}
