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
            double number = 0;
            ViewBag.BasketTotalPrice = "";
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
                        basketProduct.DbCount = dbProduct.Count;
                    }
                    basketProduct.ProductTotalPrice = basketProduct.BasketCount * basketProduct.Price;
                    number += basketProduct.ProductTotalPrice;
                }
                ViewBag.BasketTotalPrice = number;
            }
            return View(basketProducts);
        }


        public IActionResult AddBasket(int? id)
        {
            double basketTotalPrice = 0;

            if (id == null) return NotFound();
            Product dbproduct =  _db.Products.FirstOrDefault(x=>x.Id==id);
            
            if (dbproduct == null) return NotFound();
            List<BasketVM> basketProducts;
            if (Request.Cookies["fbasket"] == null)
            {
                basketProducts = new List<BasketVM>();
            }
            else
            {
                basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["fbasket"]);
            }

            BasketVM existProduct = basketProducts.FirstOrDefault(p => p.Id == id);
            
            if (existProduct == null)
            {
                BasketVM newproduct = new BasketVM
                {
                    Id = dbproduct.Id,
                    BasketCount = 1
                };
                basketProducts.Add(newproduct);
            }
            else
            {
                existProduct.BasketCount++;
            }

            foreach (var basketProduct in basketProducts)
            {
                Product dbProduct = _db.Products.FirstOrDefault(x => x.Id == basketProduct.Id);
                if (dbProduct != null)
                {
                    basketProduct.Price = dbProduct.Price;
                    basketProduct.Image = dbProduct.Image;
                    basketProduct.Title = dbProduct.Title;
                    basketProduct.DbCount = dbProduct.Count;
                }
                basketProduct.ProductTotalPrice = basketProduct.BasketCount * basketProduct.Price;
                basketTotalPrice += basketProduct.ProductTotalPrice;
            }

            string fbasket = JsonConvert.SerializeObject(basketProducts);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
            var anonymObject = new
            {
                BasketTotalPrice = basketTotalPrice,
                BasketProductCount = basketProducts.Count()
            };

            return Ok(anonymObject);
            //return RedirectToAction("Index","Home");
        }


        //public IActionResult ProductCountPlusAjax(int? id)
        //{
        //    string basketProducts = Request.Cookies["fbasket"];
        //    List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(basketProducts);
        //    BasketVM product = products.FirstOrDefault(p => p.Id == id);
        //    product.BasketCount++;
        //    var dbProduct = _db.Products.FirstOrDefault(x => x.Id == id);

        //    string fbasket = JsonConvert.SerializeObject(products);
        //    Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });

        //    return Ok(product.BasketCount);
        //}

        public IActionResult ProductCountPlusAxious([FromForm] int id)
        {
            double basketTotalPrice = 0;
            string basket = Request.Cookies["fbasket"];
            List<BasketVM> basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            BasketVM product = basketProducts.FirstOrDefault(p => p.Id == id);

            product.BasketCount++;
            int basketCount = product.BasketCount;
            foreach (var basketProduct in basketProducts)
            {
                Product dbProduct = _db.Products.FirstOrDefault(x => x.Id == basketProduct.Id);
                if (dbProduct != null)
                {
                    basketProduct.Price = dbProduct.Price;
                    basketProduct.Image = dbProduct.Image;
                    basketProduct.Title = dbProduct.Title;
                    basketProduct.DbCount = dbProduct.Count;
                }
                basketProduct.ProductTotalPrice = basketProduct.BasketCount * basketProduct.Price;
                basketTotalPrice += basketProduct.ProductTotalPrice;
            }

            string fbasket = JsonConvert.SerializeObject(basketProducts);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
            var anonymObject = new
            {
                BasketProducts = basketProducts,
                ProductBasketCount = basketCount,
                BasketTotalPrice = basketTotalPrice
            };
            return Ok(anonymObject);
        }

        public IActionResult ProductCountMinus(int? id)
        {
            string basketProduct = Request.Cookies["fbasket"];
            List<BasketVM> products = JsonConvert.DeserializeObject<List<BasketVM>>(basketProduct);
            BasketVM product = products.FirstOrDefault(p => p.Id == id);

            if (product.BasketCount > 1)
            {
                product.BasketCount--;
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
            double basketTotalPrice = 0;
            string basket = Request.Cookies["fbasket"];
            List<BasketVM> basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            BasketVM product = basketProducts.FirstOrDefault(p => p.Id == id);

            basketProducts.Remove(product);

            foreach (var basketProduct in basketProducts)
            {
                Product dbProduct = _db.Products.FirstOrDefault(x => x.Id == basketProduct.Id);
                if (dbProduct != null)
                {
                    basketProduct.Price = dbProduct.Price;
                    basketProduct.Image = dbProduct.Image;
                    basketProduct.Title = dbProduct.Title;
                    basketProduct.DbCount = dbProduct.Count;
                }
                basketProduct.ProductTotalPrice = basketProduct.BasketCount * basketProduct.Price;
                basketTotalPrice += basketProduct.ProductTotalPrice;
            }

            string fbasket = JsonConvert.SerializeObject(basketProducts);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
            var anonymObject = new
            {
                BasketTotalPrice = basketTotalPrice,
                BasketProductCount = basketProducts.Count()
            };
            return Ok(anonymObject);
        }

        
    }
}
