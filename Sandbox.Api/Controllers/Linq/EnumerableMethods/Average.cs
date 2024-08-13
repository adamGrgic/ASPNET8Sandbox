using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Controllers.Linq.EnumerableMethods
{
    // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.average?view=net-8.0

    // get average of a sequence of values
    // can be used for many different data 

    [Route("[controller]/[action]")]
    public class Average : Controller
    {
        public IActionResult V1()
        {
            int[] numbers = { 25, 69, 500, 746 };

            double? average = numbers.Average();

            return Ok();
        }
    }
}
