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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _context.Products;
            return Ok(products);
        }

        // GET api/<ProductController>/5
        [HttpGet("{Id}")]
        public IActionResult GetSingleProduct(int id)
        {
            var singleProduct = _context.Products.Where(p => p.Id == id);
            return Ok(singleProduct);
        }

        //UNFINISHED ENDPOINT TO FIND PRODUCTS FOR SALE BY USER
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
        public IActionResult PostNewProduct([FromBody]Product value)
        {
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
        [HttpDelete]
        public void Delete(int id)
        {

        }
    }
}
