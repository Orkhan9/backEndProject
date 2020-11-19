using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.Models
{
    public class Expert
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [Required,StringLength(100)]
        public string Image { get; set; }
        [StringLength(50)]
        public string Profession { get; set; }
    }
}
