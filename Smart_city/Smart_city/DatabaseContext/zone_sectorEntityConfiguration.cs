using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smart_city.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_city.DatabaseContext
{
    public class zone_sectorEntityConfiguration
    : IEntityTypeConfiguration<zone_sector>
    {

        public void Configure(EntityTypeBuilder<zone_sector> zone_sectorConfiguration)
        {
            zone_sectorConfiguration.Property(b => b.ZonaId)
                .UseIdentityColumn();


            zone_sectorConfiguration.Property(b => b.ZonaNume)
                .IsRequired();

            zone_sectorConfiguration.HasOne(o => o.Sector)
              .WithMany()
              .IsRequired(true)
              .HasForeignKey("SectorId");

        }


    }
}
