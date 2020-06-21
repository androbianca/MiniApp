using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Entities
{
    public class ConcertSingerConfiguration : BaseEntityConfiguration, IEntityTypeConfiguration<ConcertSinger>
    {
        public void Configure(EntityTypeBuilder<ConcertSinger> builder)
        {
            builder.HasKey(x => new { x.SingerId, x.ConcertId });

            builder.HasOne(x => x.Singer)
                .WithMany(y => y.Concerts)
                .HasForeignKey(y => y.SingerId);

            builder.HasOne(x => x.Concert)
                .WithMany(y => y.Singers)
                .HasForeignKey(y => y.ConcertId);

        }
    }
}