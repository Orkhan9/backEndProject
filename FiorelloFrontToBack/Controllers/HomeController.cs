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
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                SliderText = _db.SliderTexts.FirstOrDefault(),
                SliderImages=_db.SliderImages,
                Categories=_db.Categories,
                Bio=_db.Bios.FirstOrDefault(),
                About=_db.Abouts.FirstOrDefault(),
                Experts=_db.Experts,
                Subscribe=_db.Subscribes.FirstOrDefault()
            };
            return View(homeVM);
        }
    }
}
