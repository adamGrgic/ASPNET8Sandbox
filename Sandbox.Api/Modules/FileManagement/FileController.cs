using Microsoft.AspNetCore.Mvc;
using Sandbox.Api.SandboxUtils;

namespace Sandbox.Api.Modules.FileManagement
{
    [Route("[controller]/[action]")]
    public class FileController : Controller
    {

        [HttpGet]
        public IActionResult CreateTextFile(string name)
        {

            FileUtility.CreateTextFile(name);

            return Ok();
        }
    }
}
