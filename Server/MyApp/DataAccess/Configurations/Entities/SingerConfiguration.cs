using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations.Entities
{
    public class SingerConfiguration : BaseEntityConfiguration, IEntityTypeConfiguration<Singer>
    {
        public void Configure(EntityTypeBuilder<Singer> builder)
        {
            // needs to be many to many, another table should be added with SingerId and ConcertId
            builder.HasOne(x => x.Concert)
                 .WithMany(y => y.Singers)
                 .HasForeignKey(z => z.ConcertId);
        }
    }
}
