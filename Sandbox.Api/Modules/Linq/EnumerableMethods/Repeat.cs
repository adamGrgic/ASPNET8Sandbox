using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Controllers.Linq.EnumerableMethods
{
    public class Repeat : ControllerBase
    {

        public IActionResult BasicExample()
        {
            IEnumerable<string> strings =
                Enumerable.Repeat("I like programming.", 15);

            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }
            return Ok();
        }
    }
}
