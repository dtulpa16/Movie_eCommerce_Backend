using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


#nullable disable

namespace eCommerceStarterCode.Models
{
    public class FileModel
    {


        [Key]
        public int PhotoId { get; set; }

        public string FileName { get; set; }

        public IFormFile FormFile{ get; set; }





    }
}