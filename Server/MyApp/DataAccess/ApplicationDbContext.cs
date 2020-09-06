using DataAccess.Configurations.Entities;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
: base(options) { }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<ConcertSinger> ConcertSinger { get; set; }
        public DbSet<ConcertView> ConcertView { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new SingerConfiguration());
            modelBuilder.ApplyConfiguration(new ConcertConfiguration());
            modelBuilder.ApplyConfiguration(new ConcertSingerConfiguration());

            modelBuilder.Entity<Location>().HasData(new { Id = Guid.Parse("bf6d2c0e-b636-4f51-94ff-aab3406427c8"), Country = "Romania", County = "Bucuresti", Name = "Bucuresti", Street = "Strada z" },
                new { Id = Guid.Parse("bf6d2c1e-b636-4f51-94ff-aab3406427c8"), Country = "Romania", County = "Iasi", Name = "Iasi", Street = "Strada x" },
                new { Id = Guid.Parse("bf6d2c2e-b636-4f51-94ff-aab3406427c8"), Country = "Romania", County = "Brasov", Name = "Brasov", Street = "Strada y" });

            modelBuilder.Entity<Singer>().HasData(new
            {
                Id = Guid.Parse("5880919e-ab87-4f3b-aac3-d12513a40103"),
                Name = "Rihanna",
                MusicType = "Pop",
            },
            new
            {
                Id = Guid.Parse("4880919e-ab87-4f3b-aac3-d12513a40103"),
                Name = "The weekend",
                MusicType = "Rock",
            },
            new
            {
                Id = Guid.Parse("3880919e-ab87-4f3b-aac3-d12513a40103"),
                Name = "Delia",
                MusicType = "Jazz",
            });

        }
    }
}
