using Allup.DAL;
using Allup.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
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
            ViewBag.Brands = new SelectList(_context.Brands.ToList(), "Id", "Name");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            ViewBag.Categories = new SelectList(_context.Categories.ToList(), "Id", "Name");
            ViewBag.Brands = new SelectList(_context.Brands.ToList(), "Id", "Name");

            if (!ModelState.IsValid)
            {
                return View();
            }

            bool CategoryNameExist = _context.Products.Any(p => p.Name.ToLower() == product.Name.ToLower());

            if (CategoryNameExist)
            {
                ModelState.AddModelError("Name", "Product with this name is already exist");
                return View();
            }

            Product newProduct = new Product()
            {
                Name = product.Name,
                Price = product.Price,
                DiscountPrice = product.DiscountPrice,
                CategoryId = product.CategoryId,
                BrandId = product.BrandId,
                IsFeatured = product.IsFeatured,
                IsBestseller = product.IsBestseller,
                IsNewArrival = product.IsNewArrival,
                IsComputer = product.IsComputer,
                IsSmartphone = product.IsSmartphone,
                IsGameConsoles = product.IsGameConsoles,
                StockCount = product.StockCount,
                IsSpecialProduct = product.IsSpecialProduct,
                Description = product.Description,
                CreatedAt = DateTime.Now
            };

            await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();

            return RedirectToAction("index");
        }

        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();

            Product dbProduct = _context.Products.FirstOrDefault(p => p.Id == id);

            if (dbProduct == null) return NotFound();

            return View(dbProduct);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Product dbProduct = _context.Products.Include(p => p.Category).Include(p => p.Brand).FirstOrDefault(p => p.Id == product.Id);

            Product dbProductName = _context.Products.FirstOrDefault(c => c.Name.ToLower() == product.Name.ToLower());

            if (dbProduct == null) return NotFound();

            if (dbProduct != null)
            {
                if (dbProduct.Name != dbProductName.Name)
                {
                    ModelState.AddModelError("Name", "Product with this name is already exist");
                    return View();
                }
            }

            dbProduct.Name = product.Name;
            dbProduct.Price = product.Price;
            dbProduct.DiscountPrice = product.DiscountPrice;
            dbProduct.CategoryId = product.CategoryId;
            dbProduct.BrandId = product.BrandId;
            dbProduct.IsFeatured = product.IsFeatured;
            dbProduct.IsBestseller = product.IsBestseller;
            dbProduct.IsNewArrival = product.IsNewArrival;
            dbProduct.IsComputer = product.IsComputer;
            dbProduct.IsSmartphone = product.IsSmartphone;
            dbProduct.IsGameConsoles = product.IsGameConsoles;
            dbProduct.StockCount = product.StockCount;
            dbProduct.IsSpecialProduct = product.IsSpecialProduct;
            dbProduct.Description = product.Description;
            dbProduct.UpdatedAt = DateTime.Now;


            await _context.SaveChangesAsync();

            return RedirectToAction("index");
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            Product dbProduct = _context.Products.Include(pi=>pi.ProductImages).Include(p => p.Category).Include(p => p.Brand).FirstOrDefault(p=>p.Id == id);

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