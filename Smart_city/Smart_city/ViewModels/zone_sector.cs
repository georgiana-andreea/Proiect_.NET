using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_city.ViewModels
{
    public class zone_sector
    {
        
        [Key]
        public int ZonaId { get; set; }

        public string ZonaNume { get; set; }

        public virtual Sector Sector { get; set; }
    }
}
