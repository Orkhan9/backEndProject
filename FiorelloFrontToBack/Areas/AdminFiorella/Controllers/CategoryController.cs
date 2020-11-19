using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiorelloFrontToBack.DAL;
using FiorelloFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloFrontToBack.Areas.AdminFiorella.Controllers
{
    [Area("AdminFiorella")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> categories = _db.Categories.ToList();
            return View(categories);
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Category category = await _db.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            bool isExistCategory = _db.Categories.Any(c => c.Name.ToLower() == category.Name.ToLower());
            if (isExistCategory)
            {
                ModelState.AddModelError("Name", "Bu adda kateqoriya movcuddur");
                return View();
            }
            await _db.Categories.AddAsync(category);
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Category category = await _db.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (id == null) return NotFound();

            Category dbCategory = await _db.Categories.FindAsync(id);
            if (dbCategory == null) return NotFound();

            Category checkCategory = _db.Categories.FirstOrDefault(c => c.Name.ToLower() == category.Name.ToLower());

            if (checkCategory != null)
            {
                if (dbCategory.Name != checkCategory.Name)
                {
                    ModelState.AddModelError("Name", "Bu adda kateqoriya movcuddur");
                    return View();
                }
            }
            
            dbCategory.Name = category.Name;
            dbCategory.Description = category.Description;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Category category = await _db.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCategory(int? id)
        {
            if (id == null) return NotFound();
            Category category = await _db.Categories.FindAsync(id);
            if (category == null) return NotFound();

            _db.Categories.Remove(category);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
