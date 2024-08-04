using Microsoft.AspNetCore.Mvc;

namespace SandboxModule.Modules.LINQDictionary
{
    [Route("[controller]/[action]")]
    public class Cast : Controller
    {
        public IActionResult Index()
        {
            System.Collections.ArrayList fruits = new System.Collections.ArrayList();
            fruits.Add("mango");
            fruits.Add("apple");
            fruits.Add("lemon");

            IEnumerable<string> query =
                fruits.Cast<string>().OrderBy(fruit => fruit).Select(fruit => fruit);
            return Ok(query);
        }
    }
}
