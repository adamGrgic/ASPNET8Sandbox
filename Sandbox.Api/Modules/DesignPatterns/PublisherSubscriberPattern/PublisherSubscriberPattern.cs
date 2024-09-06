using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DesignPatterns.PublisherSubscriberPattern
{
    public class PublisherSubscriberPattern : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
