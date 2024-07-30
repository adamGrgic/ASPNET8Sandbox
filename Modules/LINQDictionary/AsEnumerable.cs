using Microsoft.AspNetCore.Mvc;

namespace SandboxModule.Modules.LINQDictionary
{
    [Route("[controller]/[action]")]
    public class AsEnumerable : Controller
    {
        // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.asenumerable?view=net-8.0


        public bool V1()
        {


            return true;
        }
    }
}
