using FiorelloFrontToBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.ViewModels
{
    public class HomeVM
    {
        public SliderText SliderText { get; set; }
        public IEnumerable<SliderImage> SliderImages { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public Bio Bio { get; set; }
        public About About { get; set; }
        public IEnumerable<Expert> Experts { get; set; }
        public Subscribe Subscribe { get; set; }
    }
}
