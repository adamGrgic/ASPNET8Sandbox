using BenchmarkDotNet.Running;
using Microsoft.AspNetCore.Mvc;
using Sandbox.Api.Modules.Linq.EnumerableMethods.Select.Service;

namespace Sandbox.Api.Modules.Linq.EnumerableMethods.Select
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SelectController : ControllerBase
    {
        private readonly ISelectService _selectService;
        public SelectController(ISelectService selectService)
        {
            _selectService = selectService;
        }

        [HttpGet]
        public IActionResult SelectBasic()
        {
            _selectService.SelectServiceV1();
            
            return Ok(true);
        }
    }
}
