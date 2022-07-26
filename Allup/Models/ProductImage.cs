using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Allup.Models
{
    public class ProductImage
    {
        public int Id { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }
        public string ImageURL { get; set; }
        public bool IsMain { get; set; }

        public bool  IsSecond { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}