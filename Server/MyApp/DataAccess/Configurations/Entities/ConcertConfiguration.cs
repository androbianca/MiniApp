using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Entities
{
    public class ConcertConfiguration : BaseEntityConfiguration, IEntityTypeConfiguration<Concert>
    {
        public void Configure(EntityTypeBuilder<Concert> builder)
        {
            builder.Property(x => x.Price).HasMaxLength(6);

            builder.HasOne(a => a.Location)
             .WithMany(b => b.Concerts)
             .HasForeignKey(c => c.LocationId);

        }
    }
}
