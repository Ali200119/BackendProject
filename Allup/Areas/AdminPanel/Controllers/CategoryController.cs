using Allup.DAL;
using Allup.Extentions;
using Allup.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Areas.AdminPanel.Controllers
{
    [Area(nameof(AdminPanel))]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CategoryController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();
            
            return View(categories);
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

            bool CategoryNameExist = _context.Categories.Any(c => c.Name.ToLower() == category.Name.ToLower());

            if(CategoryNameExist)
            {
                ModelState.AddModelError("Name", "Category with this name is already exist");
                return View();
            }

            if (category.Image == null)
            {
                ModelState.AddModelError("Iamge", "The Image field is required");
                return View();
            }

            if (!category.Image.IsImage())
            {
                ModelState.AddModelError("Image", "Please add only image");
                return View();
            }

            Category newCategory = new Category()
            {
                Name = category.Name,
                CreatedAt = DateTime.Now,
                ImageURL = await category.Image.SaveImage(_env, "assets", "images")
            };

            await _context.Categories.AddAsync(newCategory);
            await _context.SaveChangesAsync();
            
            return RedirectToAction("index");
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            Category dbcategory = _context.Categories.FirstOrDefault(c=>c.Id == id);

            if (dbcategory == null) return NotFound();

            return View(dbcategory);
        }

        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();

            Category category = _context.Categories.FirstOrDefault(c => c.Id == id);

            if (category == null) return NotFound();

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Category dbCategory = _context.Categories.FirstOrDefault(c => c.Id == category.Id);

            Category dbCategoryName = _context.Categories.FirstOrDefault(c => c.Name.ToLower() == category.Name.ToLower());

            if (dbCategory == null) return NotFound();

            if (dbCategoryName != null)
            {
                if (dbCategory.Name != dbCategoryName.Name)
                {
                    ModelState.AddModelError("Name", "Category with this name is already exist");
                    return View();
                }
            }

            if (!category.Image.IsImage())
            {
                ModelState.AddModelError("Image", "Please add only image");
                return View();
            }

            dbCategory.Name = category.Name;
            dbCategory.ImageURL = await category.Image.SaveImage(_env, "assets", "image");

            await _context.SaveChangesAsync();

            return RedirectToAction("index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            Category dbCategory = _context.Categories.FirstOrDefault(c => c.Id == id);

            if (dbCategory == null) return NotFound();

            string path = Path.Combine(_env.WebRootPath, "assets", "images", dbCategory.ImageURL);

            Helpers.Helper.DeleteFile(path);

            _context.Categories.Remove(dbCategory);

            await _context.SaveChangesAsync();

            return RedirectToAction("index");
        }
    }
}
