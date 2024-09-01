using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DesignPatterns
{
    public class FactoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
