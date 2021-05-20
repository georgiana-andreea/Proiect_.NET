using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smart_city.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_city.DatabaseContext
{
    public class raport_terenEntityConfiguration
    : IEntityTypeConfiguration<raport_teren>
    {

        public void Configure(EntityTypeBuilder<raport_teren> raport_terenConfiguration)
        {
            raport_terenConfiguration.Property(b => b.RaportId)
                .UseIdentityColumn();


            raport_terenConfiguration.Property(b => b.StareIncarcare)
                .IsRequired();

           raport_terenConfiguration.HasOne(o => o.Zona)
              .WithMany()
              .IsRequired(true)
              .HasForeignKey("ZonaId");

            raport_terenConfiguration.HasOne(o => o.Pubela)
              .WithMany()
              .IsRequired(true)
              .HasForeignKey("PubelaId");

        }

       
    }
}
