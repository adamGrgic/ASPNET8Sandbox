using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DesignPatterns
{
    public class CommandPattern : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
