using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Xml;
using FastFood.Models.Enums;

namespace FastFood.Models
{
    public class Order
    {
        public Order()
        {
            this.OrderItems=new List<OrderItem>();
            this.Type = OrderType.ForHere;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Customer { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public OrderType Type { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        public int EmployeeId { get; set; }
        [Required]
        public Employee Employee { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
