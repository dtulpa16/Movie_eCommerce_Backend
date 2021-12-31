using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceStarterCode.Models;
using eCommerceStarterCode.Data;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            return await _context.Products
                .Select(x => new Product()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    Description = x.Description,
                    Genres = x.Genres,
                    UserId = x.UserId,
                    ImageName = x.ImageName,
                    ImageSrc = String.Format("{0}://{1}{2}/Images/{3}", Request.Scheme, Request.Host, Request.PathBase, x.ImageName)
                })
                .ToListAsync();

        }

        // GET api/product/{id}
        [HttpGet("{Id}")]
        public IActionResult GetSingleProduct(int id)
        {
            var singleProduct = _context.Products.Where(p => p.Id == id);
            return Ok(singleProduct);
        }

        // GET api/product/selling/{userId}
        [HttpGet("selling/{userId}"), Authorize]
        public IActionResult GetUserProductsForSale(string id)
        {
            var userId = User.FindFirstValue("id");
            var usersProductsForSale = _context.Products.Include(p => p.UserId).Where(p => p.UserId == userId);
            return Ok(usersProductsForSale);
        }

        // GET api/searchresults/searchterm
        [HttpGet("searchresults{searchTerm}")]
        public IActionResult GetSearchResults(string searchTerm)
        {
            // get all products with search term in name
            var products = _context.Products.Include(p => p.Genres).ToList().Where(p => p.Name.ToLower().Contains(searchTerm.ToLower()));
            return Ok(products);
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ActionResult<Product>> PostNewProduct([FromForm]Product value)
        {
            value.ImageName = await SaveImage(value.ImageFile);
            _context.Products.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        // PUT api/<ProductController>/5
        [HttpPut()]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{productId}")]
        public IActionResult Remove(int productId)
        {
            var singleProduct = _context.Products.Where(p => p.Id == productId).SingleOrDefault();
            _context.Products.Remove(singleProduct);
            _context.SaveChanges();
            return Ok(singleProduct);
        }

        [NonAction]
        public async Task<string> SaveImage(IFormFile imageFile)
        {
            string imageName = new String(Path.GetFileNameWithoutExtension(imageFile.FileName).Take(10).ToArray()).Replace(' ', '-');
            imageName = imageName + DateTime.Now.ToString("yymmssfff") + Path.GetExtension(imageFile.FileName);
            var imagePath = Path.Combine(_hostEnvironment.ContentRootPath, "Images", imageName);
            using (var fileStream = new FileStream(imagePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }
            return imageName;
        }
    }
}
