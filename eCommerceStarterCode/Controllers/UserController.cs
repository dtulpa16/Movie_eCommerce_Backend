using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace eCommerceStarterCode.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }
        // <baseurl>/api/user


        [HttpGet, Authorize]
        public IActionResult GetCurrentUser()
        {
            var userId = User.FindFirstValue("id");
            var user = _context.Users.Find(userId);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }


<<<<<<< HEAD
        public IActionResult Post([FromBody]User value)
=======
        public IActionResult Post([FromBody] User value)
>>>>>>> faeeb9e5992fb6ee65f4c8fabca8000fdd118d91
        {
            _context.Users.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }
    }
}
