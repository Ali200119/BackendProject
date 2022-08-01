using System;
using System.Collections.Generic;

namespace Allup.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Nullable<double> DiscountPrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsBestseller { get; set; }
        public bool IsNewArrival { get; set; }
        public bool IsComputer { get; set; }
        public bool IsSmartphone { get; set; }
        public bool IsGameConsoles { get; set; }
        public bool IsSpecialProduct { get; set; }
        public Nullable<DateTime> CreatedAt { get; set; }
        public Nullable<DateTime> UpdatedAt { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        public int StockCount { get; set; }
        public string Description { get; set; }
    }
}