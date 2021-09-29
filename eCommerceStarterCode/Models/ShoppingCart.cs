using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;




namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {
     
        
        public int Quantity { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public Product Products { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

    }
}

