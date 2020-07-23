using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace OrderApi.Models{

    public class Order
    {
        [Key]
        public int OrderId {get;set;}
        [Required]
        [MinLength(3)]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage="Cannot include numbers or sybols")]
        public string Name {get;set;}
        public List<OrderItem> Items {get;set;}
        public DateTime CreatedAt { get;set; } = DateTime.Now;
        public DateTime UpdatedAt { get;set; } = DateTime.Now;
    }
}