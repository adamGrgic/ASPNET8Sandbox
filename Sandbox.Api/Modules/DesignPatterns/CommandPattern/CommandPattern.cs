using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DesignPatterns.CommandPattern
{
    public class CommandPattern : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
