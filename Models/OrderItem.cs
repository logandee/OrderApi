using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApi.Models{

    public class OrderItem
    {
        [Key]
        public int OrderItemId {get;set;}
        [ForeignKey("Order")]
        public Order OrderId {get;set;}
        [ForeignKey("Product")]
        public Product ProductId {get;set;}
        public Order Order {get;set;}
        public Product Product {get;set;}
        public int ItemQty {get;set;}
        public DateTime CreatedAt { get;set; } = DateTime.Now;
        public DateTime UpdatedAt { get;set; } = DateTime.Now;
    }
}