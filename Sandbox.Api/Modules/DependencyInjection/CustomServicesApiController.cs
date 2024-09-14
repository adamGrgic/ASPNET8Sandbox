using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DependencyInjection
{
    [ApiController]
    [Route("/cache")]
    public class CustomServicesApiController : Controller
    {
        [HttpGet("big-cache")]
        public ActionResult<object> GetOk([FromKeyedServices("big")] ICache cache)
        {
            return cache.Get("data-mvc");
        }
    }
}
