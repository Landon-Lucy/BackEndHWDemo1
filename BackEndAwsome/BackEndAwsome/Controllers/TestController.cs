using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEndAwsome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {

        List<TestItem> items = new List<TestItem>()
        {
            new TestItem(1, "Item 1"),
            new TestItem(2, "Item 2"),
            new TestItem(3, "Item 3"),
        };

        [HttpGet("items")]

        public IActionResult GetItems()
        {
            //get this from database
            var items = new List<ClassLibrary.Models.TestItem>()
            {
                new ClassLibrary.Models.TestItem() {Id = 1 }
            };

            //If else or try catch usually here
            return Ok(items);
        }

        [HttpPost("items")]

        public IActionResult PostItem(ClassLibrary.Models.TestItem item)
        {
            //save to database
            items.Add(item);

            return Ok(item);
        }

        [HttpDelete("items/{id}")]
        public IActionResult DeleteItem(int id)
        {
            //delete from database

            foreach (TestItem item in items)
            {
                if (item.Id == id)
                {
                    items.Remove(item);
                    break;
                }
            }

            return Ok();
        }

        [HttpPut("items/{id}")]
        public IActionResult PutItem(int id)
        {
            //update in database
            foreach (TestItem item in items)
            {
                if (item.Id == id)
                {
                    item.Name = "Updated Name";
                    break;
                }
            }

            return Ok();
        }
    }
}
