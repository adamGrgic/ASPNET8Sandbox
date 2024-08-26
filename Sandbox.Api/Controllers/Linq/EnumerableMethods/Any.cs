using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Controllers.Linq.EnumerableMethods
{
    public class Any : Controller
    {
        public IActionResult BasicExample()
        {
            List<int> numbers = new List<int> { 1, 2 };
            bool hasElements = numbers.Any();

            Console.WriteLine("The list {0} empty.",
                hasElements ? "is not" : "is");
            return Ok();
        }
    }
}
