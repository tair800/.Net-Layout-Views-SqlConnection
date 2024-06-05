using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;

namespace WebApplication6.DAL
{
    public class CarDbContext : DbContext
    {
        public CarDbContext(DbContextOptions options) : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=T490;Database=CarDb;Trusted_Connection=True;TrustServerCertificate=True");
        //}

        public DbSet<Car> Cars { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Model> Models { get; set; }


    }
}
