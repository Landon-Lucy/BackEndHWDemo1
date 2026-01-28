using ClassLibrary.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackEndAwsome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {

        private static readonly List<TestItem> items = new List<TestItem>()
        {
            new TestItem(1, "Item 1"),
            new TestItem(2, "Item 2"),
            new TestItem(3, "Item 3"),
        };

        public static int nextId = 4;
        [HttpGet("items")]

        public IActionResult GetItems()
        {
            //get this from database
            //var items = new List<ClassLibrary.Models.TestItem>()
            //{
            //    new ClassLibrary.Models.TestItem() {Id = 1 }
            //};

            //If else or try catch usually here
            return Ok(items);
        }

        [HttpPost("items")]

        public IActionResult PostItem([FromBody] TestItem newItem)
        {
            newItem.Id = nextId;
            nextId++;

            items.Add(newItem);

            return Ok();
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
        public IActionResult PutItem([FromBody] TestItem newItem)
        {
            //update in database
            foreach (TestItem item in items)
            {
                if (item.Id == newItem.Id)
                {
                    item.Name = newItem.Name;
                    break;
                }
            }

            return Ok();
        }
    }
}
