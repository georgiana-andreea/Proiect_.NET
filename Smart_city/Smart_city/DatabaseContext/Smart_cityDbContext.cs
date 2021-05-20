using Microsoft.EntityFrameworkCore;
using Smart_city.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_city.DatabaseContext
{
    public class Smart_cityDbContext : DbContext
    {
        public Smart_cityDbContext(DbContextOptions<Smart_cityDbContext>options) : base(options)
        {
        }
        public DbSet<Sector> Sector { get; set; }
        public DbSet<zone_sector> zone_sector { get; set; }
        public DbSet<Pubele> Pubele { get; set; }
        public DbSet<raport_teren> raport_teren { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SectorEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PubeleEntityConfiguration());
            modelBuilder.ApplyConfiguration(new raport_terenEntityConfiguration());
            modelBuilder.ApplyConfiguration(new zone_sectorEntityConfiguration());
        }
    }
}
