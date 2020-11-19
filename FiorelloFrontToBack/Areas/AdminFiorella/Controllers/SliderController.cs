using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiorelloFrontToBack.DAL;
using FiorelloFrontToBack.Extentions;
using FiorelloFrontToBack.Helpers;
using FiorelloFrontToBack.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloFrontToBack.Areas.AdminFiorella.Controllers
{
    [Area("AdminFiorella")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IHostingEnvironment _env;
        public SliderController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.SliderImages);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderImage slider)
        {
            if (ModelState["Photos"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            int canUploadCount = 5 - (_db.SliderImages.Count());
            if (canUploadCount < slider.Photos.Length)
            {
                ModelState.AddModelError("Photos", $"Maksimum yukleye bileceyiniz shekil sayi - {canUploadCount}");
                return View();
            }

            foreach (IFormFile photo in slider.Photos)
            {
                if (!photo.IsImage())
                {
                    ModelState.AddModelError("Photos", " Zehmet olmasa shekil formati sechin");
                    return View();
                }

                if (photo.MaxLength(200))
                {
                    ModelState.AddModelError("Photos", $"{photo.FileName} Sheklinin olcusu 200 kb-dan choxdur");
                    return View();
                }


                string fileName = await photo.SaveImg(_env.WebRootPath, "img");

                SliderImage newslider = new SliderImage();
                newslider.Image = fileName;
                await _db.SliderImages.AddAsync(newslider);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            SliderImage slider = await _db.SliderImages.FindAsync(id);
            if (slider == null) return NotFound();

            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSlider(int? id)
        {
            if (id == null) return NotFound();
            SliderImage slider = await _db.SliderImages.FindAsync(id);
            if (slider == null) return NotFound();

            Helper.DeleteImage(_env.WebRootPath, "img", slider.Image);

            _db.SliderImages.Remove(slider);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            SliderImage slider = await _db.SliderImages.FindAsync(id);
            if (slider == null) return NotFound();

            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, SliderImage slider)
        {
            if (id == null) return NotFound();

            if (slider.Photo != null)
            {
                if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                {
                    return View();
                }

                if (!slider.Photo.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa shekil formati sechin");
                    return View();
                }

                if (slider.Photo.MaxLength(200))
                {
                    ModelState.AddModelError("Photo", "Sheklin maksimum olcusu 200 kb ola biler");
                    return View();
                }

                SliderImage dbslider = await _db.SliderImages.FindAsync(id);
                if (dbslider == null) return NotFound();

                Helper.DeleteImage(_env.WebRootPath, "img", dbslider.Image);

                string fileName = await slider.Photo.SaveImg(_env.WebRootPath, "img");

                dbslider.Image = fileName;
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
