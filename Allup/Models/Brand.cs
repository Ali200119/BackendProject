using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Allup.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }
        public string ImageURL { get; set; }
        public List<Product> Products { get; set; }
        public Nullable<DateTime> CreatedAt { get; set; }
        public Nullable<DateTime> UpdatedAt { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }
    }
}
