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
        private readonly ILogger _logger;
        public SelectController(ISelectService selectService, ILogger<SelectController> logger)
        {
            _selectService = selectService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult SelectBasic()
        {
            _logger.LogInformation("Executing SelectBasic");
            _selectService.SelectServiceV1();
            _logger.LogInformation("SelectBasic ran successfully");
            _logger.LogError("Something went wrong");
            return Ok(true);
        }
    }
}
