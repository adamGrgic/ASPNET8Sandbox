using Microsoft.AspNetCore.Mvc;
using Sandbox.Api.SandboxUtils;

namespace Sandbox.Api.Modules.ThreadingAndConcurrency
{
    [Route("ThreadingAndConcurrency/[action]")]
    public class BaseController : Controller
    {
        [HttpGet]
        public IActionResult CreateRandomTextFile()
        {
            var randomString = StringsUtility.GenerateRandomString(10);
            FileUtility.CreateTextFile(randomString);
            return Ok();
        }
    }
}
