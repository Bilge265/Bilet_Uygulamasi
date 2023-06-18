using Bilet_API.Entity;
using Microsoft.EntityFrameworkCore;

namespace Bilet_API.Concrete
{
    public class MyDbContext : DbContext
    {
  
        public DbSet<User> Users { get; set; }
        public DbSet<Voyage> Voyages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Otobus_proje;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
