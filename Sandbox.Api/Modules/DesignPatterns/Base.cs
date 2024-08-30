using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DesignPatterns
{
    public class Base : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
