using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eCommerceStarterCode.Controllers
{
    [Route("api/sold")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public SellerController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<SellerController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SellerController>/5
        [HttpGet("{userId}")]
        public IActionResult Get(string userId)
        {
            var itemsSold = _context.SoldTracker.Where(s => s.UserId == userId).Include(s => s.Genres);
            return Ok(itemsSold);
        }

        // POST api/<SellerController>
        [HttpPost]
        public IActionResult Post([FromBody] SoldTracker value)
        {
            _context.SoldTracker.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);

        }

        // PUT api/<SellerController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] SoldTracker soldItem)
        {
            _context.SoldTracker.Update(soldItem);
            _context.SaveChanges();
            return Ok(soldItem);
        }

        // DELETE api/<SellerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
