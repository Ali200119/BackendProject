using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Allup.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Nullable<DateTime> CreatedAt { get; set; }
        public string Address { get; set; }
        public double TotalPrice { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }

    public enum OrderStatus
    {
        Pending,
        Shipped,
        Deliviried
    }
}
