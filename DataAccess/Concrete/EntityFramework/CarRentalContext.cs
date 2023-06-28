using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;
public class CarRentalContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        string connectionString = @"Server=ERHANMATEBOOK;Database=CarRentalDatabase;Trusted_Connection=true;TrustServerCertificate=true";
        optionsBuilder.UseSqlServer(connectionString);
    }

    public DbSet<Car> Cars { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Color> Colors { get; set; }

}