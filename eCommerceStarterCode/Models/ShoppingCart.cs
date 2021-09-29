using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {
        public int Quantity { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        
    }
}

