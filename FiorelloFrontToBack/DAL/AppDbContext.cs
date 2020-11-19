using FiorelloFrontToBack.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<SliderText> SliderTexts { get; set; }
        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
    }
}
