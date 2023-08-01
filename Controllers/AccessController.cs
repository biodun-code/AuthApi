using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AuthApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccessController : ControllerBase
    {
        [HttpGet]
        [Authorize(Policy = "AdminBackOfficePolicy")]
        public IActionResult Get()
        {
            // Return an array of fruit types of your choice
            var fruits = new List<string> { "Apple", "Banana", "Orange" };
            return Ok(fruits);
        }
    }
}
