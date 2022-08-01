using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Allup.Models
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Order> Orders { get; set; }
        public List<BasketItem> BasketItems { get; set; }
    }
}