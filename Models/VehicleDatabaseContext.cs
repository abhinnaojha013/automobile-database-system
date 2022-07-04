using Microsoft.EntityFrameworkCore;

namespace automobile_database_system.Models
{
    public class VehicleDatabaseContext:DbContext
    {
        public VehicleDatabaseContext(DbContextOptions<VehicleDatabaseContext> options):base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Auto> Autos { get; set; }
    }
}
