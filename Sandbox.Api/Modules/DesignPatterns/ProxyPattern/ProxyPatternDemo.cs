using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DesignPatterns.ProxyPattern
{
    public class ProxyPatternDemo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
