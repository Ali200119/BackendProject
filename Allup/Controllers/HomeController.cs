﻿using Allup.DAL;
using Allup.Models;
using Allup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

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
                .Include(p=>p.Category)
                .Include(p=>p.Brand)
                .ToList();

            homeVM.Categories = _context.Categories.ToList();

            homeVM.BasketItems = _context.BasketItems
                .Include(b => b.User)
                .Include(b => b.Product)
                .ToList();

            homeVM.Blogs = _context.Blogs.ToList();

            homeVM.Brands = _context.Brands.ToList();

            homeVM.Orders = _context.Orders
                .Include(o=>o.User)
                .ToList();

            homeVM.OrderItems = _context.OrderItems
                .Include(oi => oi.Order)
                .Include(oi => oi.Product)
                .ToList();

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
                .Where(p=>p.IsNewArrival)
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

            return View(homeVM);
        }

        public IActionResult SearchProduct (string search)
        {
            List<Product> products = _context.Products
                .Include(p => p.Category)
                .Include(p => p.Brand)
                .OrderBy(p => p.Id)
                .Where(p=>p.Name.ToLower()
                .Contains(search.ToLower()))
                .ToList();

            return PartialView("_SearchPartial", products);
        }
    }
}