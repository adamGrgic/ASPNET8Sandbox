using Microsoft.AspNetCore.Mvc;


namespace Sandbox.Api.Controllers.Linq.EnumerableMethods
{
    [ApiController]
    [Route("[controller]")]
    public class Select : ControllerBase
    {
        public Select()
        {
            
        }

        [HttpGet(Name = "Select")]
        public IActionResult TestApi()
        {

            return Ok(true);
        }
    }
}
