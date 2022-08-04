using Allup.DAL;
using Allup.Models;
using Microsoft.AspNetCore.Mvc;
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
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return View();
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            Product product = _context.Products.Include(p => p.Category).Include(p => p.Brand).FirstOrDefault(p=>p.Id == id);

            if (product == null) return NotFound();

            return View(product);
        }
    }
}