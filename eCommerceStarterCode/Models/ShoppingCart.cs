using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations;



>>>>>>> faeeb9e5992fb6ee65f4c8fabca8000fdd118d91

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {
     
        
        public int Quantity { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
<<<<<<< HEAD
        public Product Product { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        
=======
        public Product Products { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

>>>>>>> faeeb9e5992fb6ee65f4c8fabca8000fdd118d91
    }
}

