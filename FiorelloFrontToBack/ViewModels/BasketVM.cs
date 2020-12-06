using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.ViewModels
{
    public class BasketVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public int BasketCount { get; set; } = 1;
        public int DbCount { get; set; }
        public int TotalBasketCount { get; set; }
        public double ProductTotalPrice { get; set; }
        public string UserName { get; set; }
    }
}
