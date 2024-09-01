using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DesignPatterns
{
    public class ProxyPattern : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
