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
<<<<<<< HEAD
=======
    
        // GET: api/<ShoppingCartController>
        [HttpGet]
        public IActionResult GetAllCarts()
        {
            var cart = _context.ShoppingCarts;
            return Ok(cart);
        }
>>>>>>> faeeb9e5992fb6ee65f4c8fabca8000fdd118d91

        // GET: api/shoppingcart
        //[HttpGet]
        //public IActionResult GetAllCarts()
        //{
        //    var cart = _context.ShoppingCarts;
        //    return Ok(cart);
        //}

        // GET api/ShoppingCart/{userId}
        [HttpGet("{userId}"), Authorize]
        public IActionResult GetAllCartsForUser(string id)
        {
<<<<<<< HEAD
            var userId = User.FindFirstValue("id");
            var userCarts = _context.ShoppingCarts.Include(sc => sc.Product).Where(sc => sc.IdentityUserId == userId).Select(sc => sc.Product);
            return Ok(userCarts);
=======
            var userCart = _context.ShoppingCarts.Find(id);
            return Ok(userCart);
>>>>>>> faeeb9e5992fb6ee65f4c8fabca8000fdd118d91
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
