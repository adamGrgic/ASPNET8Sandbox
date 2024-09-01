using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Controllers.Linq.EnumerableMethods
{
    public class Contains : Controller
    {
        public Contains()
        {
            
        }

        public IActionResult BasicExample()
        {
            var fruits =
            new List<string> { "apple", "passionfruit", "banana", "mango",
                    "orange", "blueberry", "grape", "strawberry" };

            IEnumerable<string> query = fruits.Where(fruit => fruit.Length < 6);

            foreach (var fruit in query)
            {
                Console.WriteLine(fruit);
            }

            return Ok();
        }
    }
}
