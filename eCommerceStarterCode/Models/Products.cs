using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace eCommerceStarterCode.Models
{
    public partial class Product
    {
        public Product()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("Genres")]
        public string Type { get; set; }
        public Genres Genres { get; set; }
        




    }
}

