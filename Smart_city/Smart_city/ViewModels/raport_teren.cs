using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_city.ViewModels
{
    public class raport_teren
    {
        
        [Key]
        public int RaportId { get; set; }

        public int StareIncarcare { get; set; }

        public virtual zone_sector Zona { get; set; }
        public virtual Pubele Pubela { get; set; }


    }

}
