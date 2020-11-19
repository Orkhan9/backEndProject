using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Qaqash bosh buraxma"),StringLength(50,ErrorMessage ="Cox getdin")]
        public string Name { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
