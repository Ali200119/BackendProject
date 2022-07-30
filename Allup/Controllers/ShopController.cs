using Allup.DAL;
using Allup.Models;
using Allup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Allup.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ShopVM shopVM = new ShopVM()
            {
                Products = _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Include(p => p.ProductImages)
                .ToList(),

                Brands = _context.Brands.ToList(),

                Features = _context.Features.ToList(),

                Quotes = _context.Quotes.ToList()
        };

            return View(shopVM);
        }
    }
}
