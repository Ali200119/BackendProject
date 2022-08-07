using Allup.DAL;
using Allup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Areas.AdminPanel.Controllers
{
    [Area(nameof(AdminPanel))]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> products = _context.Products.Include(p => p.Category).Include(p => p.Brand).ToList();

            return View(products);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_context.Categories.ToList(), "Id", "Name");
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            ViewBag.Categories = new SelectList(_context.Categories.ToList(), "Id", "Name");

            if (!ModelState.IsValid)
            {
                return View();
            }

            bool CategoryNameExist = _context.Products.Any(p => p.Name.ToLower() == product.Name.ToLower());

            if (CategoryNameExist)
            {
                ModelState.AddModelError("Name", "Category with this name is already exist");
                return View();
            }

            if (product.Image == null)
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

            Product dbProduct = _context.Products.Include(p => p.Category).Include(p => p.Brand).FirstOrDefault(p=>p.Id == id);

            if (dbProduct == null) return NotFound();

            return View(dbProduct);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            Product dbProduct = _context.Products.FirstOrDefault(p => p.Id == id);

            if (dbProduct == null) return NotFound();

            _context.Products.Remove(dbProduct);

            await _context.SaveChangesAsync();

            return RedirectToAction("index");
        }
    }
}