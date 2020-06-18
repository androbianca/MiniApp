using DataAccess.Configurations.Entities;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
: base(options) { }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Concert> Concert { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new SingerConfiguration());
            modelBuilder.ApplyConfiguration(new ConcertConfiguration());

        }
    }
}
