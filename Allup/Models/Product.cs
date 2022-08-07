using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Allup.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }
        public Nullable<double> DiscountPrice { get; set; }
        public int CategoryId { get; set; }

        [Required]
        public Category Category { get; set; }
        public int BrandId { get; set; }

        [Required]
        public Brand Brand { get; set; }
        public List<ProductImage> ProductImages { get; set; }

        [Required]
        public bool IsFeatured { get; set; }

        [Required]
        public bool IsBestseller { get; set; }

        [Required]
        public bool IsNewArrival { get; set; }

        [Required]
        public bool IsComputer { get; set; }

        [Required]
        public bool IsSmartphone { get; set; }

        [Required]
        public bool IsGameConsoles { get; set; }

        [Required]
        public bool IsSpecialProduct { get; set; }
        public Nullable<DateTime> CreatedAt { get; set; }
        public Nullable<DateTime> UpdatedAt { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }

        [Required]
        public int StockCount { get; set; }
        public string Description { get; set; }
    }
}