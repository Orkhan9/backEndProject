using FiorelloFrontToBack.DAL;
using FiorelloFrontToBack.Models;
using FiorelloFrontToBack.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorelloFrontToBack.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        public HeaderViewComponent(AppDbContext db, UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.FullName = "";
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.FullName = user.FullName;
            }

            double Total=0;
            if (Request.Cookies["fbasket"]!=null)
            {
                List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["fbasket"]);
                ViewBag.BasketCount = products.Where(x=>x.UserName==User.Identity.Name).Count();
                
                foreach (BasketVM item in products.Where(x=>x.UserName==User.Identity.Name))
                {
                    Product dbProduct = await _db.Products.FindAsync(item.Id);
                    if (dbProduct != null)
                    {
                        Total += item.BasketCount * dbProduct.Price;
                    }
                    
                }
                ViewBag.TotalPrice = Total;
            }
            else
            {
                ViewBag.BasketCount = 0;
                ViewBag.TotalPrice = 0;
            }

            Bio model = _db.Bios.FirstOrDefault();
            return View(await Task.FromResult(model));
        }


    }
}
