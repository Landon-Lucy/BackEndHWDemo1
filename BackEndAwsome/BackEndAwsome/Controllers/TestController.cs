using Microsoft.AspNetCore.Mvc;

namespace BackEndAwsome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        [HttpGet("items")]

        public IActionResult GetItems()
        {
            //get this from database
            var items = new List<ClassLibrary.Models.TestItem>()
            {
                new ClassLibrary.Models.TestItem() {id = 1 }
            };

            //If else or try catch usually here
            return Ok(items);
        }

    }
}
