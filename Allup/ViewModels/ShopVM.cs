using Allup.Models;
using System.Collections.Generic;

namespace Allup.ViewModels
{
    public class ShopVM
    {
        public List<Product> Products { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Features> Features { get; set; }
        public List<Quotes> Quotes { get; set; }
    }
}
