using Microsoft.AspNetCore.Mvc;
using SandboxModule;

namespace SandboxModule.Modules.LINQDictionary
{
    // Inherit from BaseModuleController and add "LINQDictionary" prefix
    [Route("[controller]/[action]")]
    public class LINQDictionaryBaseModule : Controller
    {
        public LINQDictionaryBaseModule()
        {
            
        }



    }
}
