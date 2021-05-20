using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smart_city.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_city.DatabaseContext
{
    public class PubeleEntityConfiguration
   : IEntityTypeConfiguration<Pubele>
    {

        public void Configure(EntityTypeBuilder<Pubele> PubeleConfiguration)
        {
            PubeleConfiguration.Property(b => b.PubelaId)
                .UseIdentityColumn();


           PubeleConfiguration.Property(b => b.PubelaNume)
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
