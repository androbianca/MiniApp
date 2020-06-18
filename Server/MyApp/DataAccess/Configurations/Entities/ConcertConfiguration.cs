using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configurations.Entities
{
   public class ConcertConfiguration : BaseEntityConfiguration, IEntityTypeConfiguration<Concert>
    {
        public void Configure(EntityTypeBuilder<Concert> builder)
        {
            builder.HasOne(a => a.Location)
             .WithOne(b => b.Concert)
             .HasForeignKey<Concert>(c => c.LocationId);

        }
    }
}
