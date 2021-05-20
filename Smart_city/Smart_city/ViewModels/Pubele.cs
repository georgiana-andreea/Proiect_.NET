using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_city.ViewModels
{
    public class Pubele
    {

        [Key]
        public int PubelaId { get; set; }
        public string PubelaNume { get; set; }

    }
}
