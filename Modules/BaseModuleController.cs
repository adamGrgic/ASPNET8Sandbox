using Microsoft.AspNetCore.Mvc;

namespace SandboxModule
{
    // Base controller for handling "Module" prefix
    [Route("[action]")]
    public class BaseModuleController : Controller {

        public BaseModuleController()
        {
            
        }

        [HttpGet]
        public ActionResult GetModule(string name)
        {
            return View(name);
        }

    }
}