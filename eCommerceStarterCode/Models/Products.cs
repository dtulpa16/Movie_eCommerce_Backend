using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;



#nullable disable

namespace eCommerceStarterCode.Models
{
    public partial class Product
    {
        
        
        
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("Genres")]
        public int GenresId { get; set; }
        public Genres Genres { get; set; }


        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        public string ImageName { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [NotMapped]
        public string ImageSrc { get; set; }



    }
}

