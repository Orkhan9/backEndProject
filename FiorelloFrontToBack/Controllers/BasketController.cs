using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiorelloFrontToBack.DAL;
using FiorelloFrontToBack.Models;
using FiorelloFrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace FiorelloFrontToBack.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _db;
        public BasketController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

            List<Product> products = _db.Products.ToList();
            foreach (Product item in products)
            {
                ViewBag.dbProductCount = item.Count;
            }

            string fbasket = Request.Cookies["fbasket"];
            List<BasketVM> basketProducts = new List<BasketVM>();
            if (fbasket != null)
            {
                basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(fbasket);

                foreach (BasketVM basketProduct in basketProducts)
                {
                    Product dbProduct =  _db.Products.FirstOrDefault(x=>x.Id==basketProduct.Id);
                    if (dbProduct != null)
                    {
                        basketProduct.Price = dbProduct.Price;
                        basketProduct.Image = dbProduct.Image;
                        basketProduct.Title = dbProduct.Title;
                    }

                }
            }

            return View(basketProducts);
        }


        public async Task<IActionResult> AddBasket(int? id)
        {
            if (id == null) return NotFound();
            Product dbproduct = await _db.Products.FindAsync(id);
            
            if (dbproduct == null) return NotFound();
            List<BasketVM> products;
            if (Request.Cookies["fbasket"] == null)
            {
                products = new List<BasketVM>();
            }
            else
            {
                products = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["fbasket"]);
            }

            BasketVM existProduct = products.FirstOrDefault(p => p.Id == id);
            
            if (existProduct == null)
            {
                BasketVM newproduct = new BasketVM
                {
                    Id = dbproduct.Id,
                    Count = 1
                };
                products.Add(newproduct);
            }
            else
            {
                existProduct.Count++;
            }

            string fbasket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });

            return Json(products.Count());
            //return RedirectToAction("Index","Home");
        }

        
        // public IActionResult ProductCountPlusAjax(int? id)
        // {
        //     string basketProducts = Request.Cookies["fbasket"];
        //     List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(basketProducts);
        //     BasketVM product=products.FirstOrDefault(p => p.Id == id);
        //     product.Count++;
        //     var dbProduct = _db.Products.FirstOrDefault(x => x.Id == id);
        //     
        //     string fbasket = JsonConvert.SerializeObject(products);
        //     Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
        //
        //     return Ok(product.Count);
        // }
        
        public IActionResult ProductCountPlusAxious([FromForm]int id)
        {
            string basketProducts = Request.Cookies["fbasket"];
            List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(basketProducts);
            BasketVM product = products.FirstOrDefault(p => p.Id == id);
            product.Count++;
            //var dbProduct = _db.Products.FirstOrDefault(x => x.Id == id);

            string fbasket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });

            return Ok(product.Count);
           // return Ok();
        }

        public IActionResult ProductCountMinus(int? id)
        {
            string basketProduct = Request.Cookies["fbasket"];
            List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(basketProduct);
            BasketVM product = products.FirstOrDefault(p => p.Id == id);

            if (product.Count > 1)
            {
                product.Count--;
            }
            else
            {
                products.Remove(product);
            }
            
            string fbasket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });

            return RedirectToAction("Index", "Basket");
        }

        
        public IActionResult RemoveProduct(int? id)
        {
            List<Product> countProducts = _db.Products.ToList();
            foreach (Product item in countProducts)
            {
                ViewBag.dbProductCount = item.Count;
            }

            string basketProducts = Request.Cookies["fbasket"];
            List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(basketProducts);
            BasketVM product = products.FirstOrDefault(p => p.Id == id);

            products.Remove(product);

            foreach (var basketProduct in products)
            {
                Product dbProduct = _db.Products.FirstOrDefault(x => x.Id == basketProduct.Id);
                if (dbProduct != null)
                {
                    basketProduct.Price = dbProduct.Price;
                    basketProduct.Image = dbProduct.Image;
                    basketProduct.Title = dbProduct.Title;
                }
            }

            string fbasket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });

            return PartialView("_BasketPartial",products);
        }

        
    }
}
