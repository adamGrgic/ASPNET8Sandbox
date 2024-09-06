using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;

namespace Sandbox.Api.Modules.System.Collections.Concurrent
{
    [Route("[controller]/[action]")]
    public class ConcurrentDictionary : Controller
    {
        [HttpGet]
        public IActionResult BasicExample()
        {
            var NUMITEMS = 64;
            var initialCapacity = 101;

            // The higher the concurrencyLevel, the higher the theoretical number of operations
            // that could be performed concurrently on the ConcurrentDictionary.  However, global
            // operations like resizing the dictionary take longer as the concurrencyLevel rises.
            // For the purposes of this example, we'll compromise at numCores * 2.
            var numProcs = Environment.ProcessorCount;
            var concurrencyLevel = numProcs * 2;
            // Construct the dictionary with the desired concurrencyLevel and initialCapacity
            ConcurrentDictionary<int, int> cd = new ConcurrentDictionary<int, int>(concurrencyLevel, initialCapacity);

            // Initialize the dictionary
            for (int i = 0; i < NUMITEMS; i++) cd[i] = i * i;

            return Ok(cd);
        }
    }
}
