using Microsoft.AspNetCore.Mvc;

namespace BackEndAwsome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : Controller
    {
        [HttpGet("items")]

        public IActionResult GetItems()
        {
            //get this from database
            var items = new List<ClassLibrary.Models.Example>()
            {
                new ClassLibrary.Models.Example() {Name = "Item1", Age = 24 },
                new ClassLibrary.Models.Example() {Name = "Item2", Age = 27 },
                new ClassLibrary.Models.Example() {Name = "Item3", Age = 19}
            };

            //If else or try catch usually here
            return Ok(items);
        }

    }
}
