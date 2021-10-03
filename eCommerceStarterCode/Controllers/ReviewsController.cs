using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using eCommerceStarterCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<ReviewsController>
        [HttpGet]
        public IActionResult GetAllReviews()
        {
            var reviews = _context.Reviews;
            return Ok(reviews);
        }

        // GET api/<ReviewsController>/5
        [HttpGet("{productId}")]
        public IActionResult GetSingleReview(int productId)
        {
            var singleReview = _context.Reviews.Where(r => r.ProductId == productId);
            return Ok(singleReview);
        }
        // POST api/Reviews
        [HttpPost]
        public IActionResult Post([FromBody]Reviews value)
        {
            _context.Reviews.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        [HttpGet("rating{productId}")]
        public IActionResult GetReviews(int productId)
        {
            var totalRating = _context.Reviews.Where(r => r.ProductId == productId).Select(a => (decimal)a.Rating).Sum();
            var numberOfReviews = _context.Reviews.Where(r => r.ProductId == productId).Count();
            var ratingsAverage = (decimal)0;
            if (totalRating == 0)
            {
                ratingsAverage = 0;
            }
            else if (numberOfReviews > 0)
            {
                ratingsAverage = totalRating / numberOfReviews;
            }

            return Ok(String.Format("{0:.##}",ratingsAverage));
        }
    }
}
