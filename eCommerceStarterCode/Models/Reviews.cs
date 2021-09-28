using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace eCommerceStarterCode.Models
{
    public class Reviews
    {
        [Key]


        public int ReviewId { get; set; }
        public string Body { get; set; }
        public int Rating { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

    }

}

    
  


            