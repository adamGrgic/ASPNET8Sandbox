using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DesignPatterns.CommandQueryResponsibiltySegregationPattern
{
    public class CQRSDemo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
