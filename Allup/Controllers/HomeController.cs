﻿using Allup.DAL;
using Allup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Allup.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();

            homeVM.Products = _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .ToList();

            homeVM.Categories = _context.Categories.ToList();

            homeVM.Blogs = _context.Blogs.ToList();

            homeVM.Brands = _context.Brands.ToList();

            homeVM.ProductImages = _context.ProductImages
                .Include(pi => pi.Product)
                .ToList();

            homeVM.Quotes = _context.Quotes.ToList();

            homeVM.Sliders = _context.Sliders.ToList();

            homeVM.Banners = _context.Banners.ToList();

            homeVM.New = _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Include(p => p.ProductImages)
                .Where(p => p.IsNewArrival)
                .ToList();

            homeVM.Bestseller = _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Where(p => p.IsBestseller)
                .ToList();

            homeVM.Featured = _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Where(p => p.IsFeatured)
                .ToList();

            homeVM.Computer = _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Include(p => p.ProductImages)
                .Where(p => p.IsComputer)
                .ToList();

            homeVM.Smartphone = _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Where(p => p.IsSmartphone)
                .ToList();

            homeVM.GameConsoles = _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .Where(p => p.IsGameConsoles)
                .ToList();

            homeVM.Features = _context.Features.ToList();

            homeVM.Users = _context.Users.ToList();

            return View(homeVM);
        }
    }
}