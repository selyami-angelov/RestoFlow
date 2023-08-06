using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestoFlow.Infrastructure.Configuration;
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

            FluenAPI.ConfigureOccupiedTables(modelBuilder);
            FluenAPI.ConfigureProducts(modelBuilder);
            FluenAPI.ConfigureReservations(modelBuilder);
            FluenAPI.ConfigureBills(modelBuilder);

            DbSeeder.SeedCategories(modelBuilder);
            DbSeeder.SeedTables(modelBuilder);
            DbSeeder.SeedProducts(modelBuilder);
            //DbSeeder.SeedOrders(modelBuilder); 
            DbSeeder.SeedOccupiedTables(modelBuilder);
            //DbSeeder.SeedReservations(modelBuilder);
            //DbSeeder.SeedReservationTables(modelBuilder);

        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<OccupiedTable> OccupiedTables { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Bill> Bills { get; set; }
    }
}
