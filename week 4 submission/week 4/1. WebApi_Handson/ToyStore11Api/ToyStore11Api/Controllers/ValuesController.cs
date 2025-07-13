using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ToyStoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ToysController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetToys()
        {
            var toys = new List<string> { "Teddy Bear", "Lego", "Doll" };
            return Ok(toys);
        }

        [HttpPost]
        public IActionResult AddToy([FromBody] string toyName)
        {
            return Ok($"You added a new toy: {toyName}");
        }
    }
}
