using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DesignPatterns
{
    public class DependencyInjectionPattern : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
