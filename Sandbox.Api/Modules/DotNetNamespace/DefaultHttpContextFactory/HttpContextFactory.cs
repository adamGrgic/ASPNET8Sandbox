using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.Features;

namespace Sandbox.Api.Modules.DotNetNamespace.DefaultHttpContextFactory
{
    [Route("[controller]/[action]")]
    public class HttpContextFactory : Controller
    {
        private readonly IHttpContextFactory _httpContextFactory;

        public HttpContextFactory(IHttpContextFactory httpContextFactory)
        {
            _httpContextFactory = httpContextFactory;
        }

        // TODO: Fix error when running this
        [HttpGet]
        public IActionResult Index()
        {
            var context = _httpContextFactory.Create(new FeatureCollection());
            return Ok(context);
        }
    }
}
