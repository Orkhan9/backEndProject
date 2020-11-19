﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public int Count { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
