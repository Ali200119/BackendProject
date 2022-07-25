using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Allup.Models
{
    public class Quotes
    {
        public int Id { get; set; }

        [NotMapped]
        public IFormFile Avatar { get; set; }
        public string ImageURL { get; set; }
        public string Quote { get; set; }
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
