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
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            double number = 0;
            ViewBag.BasketTotalPrice = "";
            string fbasket = Request.Cookies["fbasket"];
            List<BasketVM> basketProducts = new List<BasketVM>();
            List<BasketVM> userProducts = new List<BasketVM>();

            if (fbasket != null)
            {
                basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(fbasket);

                foreach (BasketVM basketProduct in basketProducts)
                {
                    if (basketProduct.UserName == User.Identity.Name)
                    {
                        Product dbProduct = _db.Products.FirstOrDefault(x => x.Id == basketProduct.Id);
                        if (dbProduct != null)
                        {
                            basketProduct.Price = dbProduct.Price;
                            basketProduct.Image = dbProduct.Image;
                            basketProduct.Title = dbProduct.Title;
                            basketProduct.DbCount = dbProduct.Count;
                            userProducts.Add(basketProduct);
                        }
                        basketProduct.ProductTotalPrice = basketProduct.BasketCount * basketProduct.Price;
                        number += basketProduct.ProductTotalPrice;
                    }
                }
                ViewBag.BasketTotalPrice = number;
            }
            return View(userProducts);
        }


        public IActionResult AddBasket(int? id)
        {
            double basketTotalPrice = 0;

            if (id == null) return NotFound();

            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

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

            BasketVM existProduct = basketProducts.FirstOrDefault(p => p.Id == id && p.UserName == User.Identity.Name);
            
            if (existProduct == null)
            {
                BasketVM newproduct = new BasketVM
                {
                    Id = dbproduct.Id,
                    BasketCount = 1,
                    UserName = User.Identity.Name
                };
                basketProducts.Add(newproduct);
            }
            else
            {
                existProduct.BasketCount++;
            }

            foreach (var basketProduct in basketProducts.Where(x=>x.UserName==User.Identity.Name))
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
                BasketProductCount = basketProducts.Where(p => p.UserName == User.Identity.Name).Count()
            };

            return Ok(anonymObject);
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
            double productTotalPrice = 0;
            string basket = Request.Cookies["fbasket"];
            List<BasketVM> basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            BasketVM product = basketProducts.FirstOrDefault(p => p.Id == id && p.UserName==User.Identity.Name);

            product.BasketCount++;
            int basketCount = product.BasketCount;
            foreach (var basketProduct in basketProducts.Where(x=>x.UserName==User.Identity.Name))
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
                if (basketProduct.Id==id)
                {
                    productTotalPrice = basketProduct.ProductTotalPrice;
                }
                basketTotalPrice += basketProduct.ProductTotalPrice;
            }

            string fbasket = JsonConvert.SerializeObject(basketProducts);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
            var anonymObject = new
            {
                BasketProducts = basketProducts,
                ProductBasketCount = basketCount,
                BasketTotalPrice = basketTotalPrice,
                ProductTotalPrice=productTotalPrice
            };
            return Ok(anonymObject);
        }

        public IActionResult ProductCountMinusAxious(int? id)
        {
            double basketTotalPrice = 0;
            double productTotalPrice = 0;
            string basket = Request.Cookies["fbasket"];
            List<BasketVM> basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            BasketVM product = basketProducts.FirstOrDefault(p => p.Id == id);

            if (product.BasketCount > 1)
            {
                product.BasketCount--;
            }
            else
            {
                basketProducts.Remove(product);
            }

            int basketCount = product.BasketCount;
            foreach (var basketProduct in basketProducts.Where(x=>x.UserName==User.Identity.Name))
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
                if (basketProduct.Id == id)
                {
                    productTotalPrice = basketProduct.ProductTotalPrice;
                }
                basketTotalPrice += basketProduct.ProductTotalPrice;
            }

            string fbasket = JsonConvert.SerializeObject(basketProducts);
            Response.Cookies.Append("fbasket", fbasket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
            var anonymObject = new
            {
                BasketProducts = basketProducts,
                ProductBasketCount = basketCount,
                BasketTotalPrice = basketTotalPrice,
                ProductTotalPrice = productTotalPrice
            };
            return Ok(anonymObject);
        }

        
        public IActionResult RemoveProduct(int? id)
        {
            double basketTotalPrice = 0;
            string basket = Request.Cookies["fbasket"];
            List<BasketVM> basketProducts = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            BasketVM product = basketProducts.FirstOrDefault(p => p.Id == id);

            basketProducts.Remove(product);

            foreach (var basketProduct in basketProducts.Where(x=>x.UserName==User.Identity.Name))
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
                BasketProductCount = basketProducts.Where(x=>x.UserName==User.Identity.Name).Count()
            };
            return Ok(anonymObject);
        }

        
    }
}
