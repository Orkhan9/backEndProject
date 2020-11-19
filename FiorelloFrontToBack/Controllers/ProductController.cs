using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiorelloFrontToBack.DAL;
using FiorelloFrontToBack.Models;
using FiorelloFrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiorelloFrontToBack.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        public ProductController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.ProductCount = _db.Products.Count();
            return View();
        }

        public IActionResult Load(int skip)
        {
            if (skip >= _db.Products.Count())
            {
                return Content("Get qumla oyna");
            }
            IEnumerable<Product> model = _db.Products.Include(p => p.Category).Skip(skip).Take(8);
            return PartialView("_ProductPartial",model);
        }

        public IActionResult Search(string search)
        {
            IEnumerable<Product> model = _db.Products.Where(p => p.Title.Contains(search)).OrderByDescending(p => p.Id).Take(10);
            return PartialView("_SearchProductPartial",model);
        }
    }
}
