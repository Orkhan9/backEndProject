using FiorelloFrontToBack.DAL;
using FiorelloFrontToBack.Models;
using FiorelloFrontToBack.ViewModels;
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
        public HeaderViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            double Total=0;
            if (Request.Cookies["fbasket"]!=null)
            {
                List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["fbasket"]);
                ViewBag.BasketCount = products.Count;
                
                foreach (BasketVM item in products)
                {
                    Product dbProduct = await _db.Products.FindAsync(item.Id);
                    if (dbProduct != null)
                    {
                        Total += item.Count * dbProduct.Price;
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
