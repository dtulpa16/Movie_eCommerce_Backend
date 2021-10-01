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
    public class ShoppingCartController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ShoppingCartController(ApplicationDbContext context)
        {
            _context = context;
        }

    
        // GET: api/<ShoppingCartController>
        [HttpGet]
        public IActionResult GetAllCarts()
        {
            var cart = _context.ShoppingCarts;
            return Ok(cart);
        }

        // GET api/ShoppingCart/{userId}
        [HttpGet("{userId}")]
        public IActionResult GetAllCartsForUser(string userId)
        {
            //var userId = User.FindFirstValue("id");
            var userCarts = _context.ShoppingCarts.Include(sc => sc.Products).ToList().Where(sc => sc.UserId == userId);
            return Ok(userCarts);

        }

        // POST api/ShoppingCart
        [HttpPost]
        public IActionResult Post([FromBody]ShoppingCart value)
        {
            _context.ShoppingCarts.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        // PUT api/<ShoppingCartController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ShoppingCartController>/5
        [HttpDelete, Authorize]
        public void Delete(int id)
        {
            var deleteFromCart = _context.ShoppingCarts.Find(id);
            _context.ShoppingCarts.Remove(deleteFromCart);
            _context.SaveChanges();
        }
    }
}
