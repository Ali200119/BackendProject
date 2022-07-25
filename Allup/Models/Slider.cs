using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Allup.Models
{
    public class Slider
    {
        public int Id { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }
        public string ImageURL { get; set; }
        public string Profit { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}