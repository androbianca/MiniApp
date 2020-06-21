using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Entities
{
    public class SingerConfiguration : BaseEntityConfiguration, IEntityTypeConfiguration<Singer>
    {
        public void Configure(EntityTypeBuilder<Singer> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(20);
            builder.Property(x => x.MusicType).HasMaxLength(20);
        }
    }
}
