using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smart_city.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_city.DatabaseContext
{
    public class SectorEntityConfiguration
         : IEntityTypeConfiguration<Sector>
    {

        public void Configure(EntityTypeBuilder<Sector> sectorConfiguration)
        {
            sectorConfiguration.Property(b => b.SectorId)
                .UseIdentityColumn();

           
            sectorConfiguration.Property(b => b.SectorName)
                .HasMaxLength(50)
                .IsRequired();

        }

      
    }
}
