using Allup.Models;
using System.Collections.Generic;

namespace Allup.ViewModels
{
    public class HomeVM
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Brand> Brands { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        public List<Order> Orders { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<Quotes> Quotes { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Banner> Banners { get; set; }
    }
}