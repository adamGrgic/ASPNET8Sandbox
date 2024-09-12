using Microsoft.AspNetCore.Mvc;
using Sandbox.Api.SandboxUtils;
using System.Diagnostics;
using System.Drawing;

// move this somewhere else 
namespace Sandbox.Api.Modules.System.Collections.Concurrent
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ParallelSandbox : ControllerBase
    {
        [HttpGet]
        public IActionResult BasicExample()
        {
            long totalSizeParallel = 0;
            long totalSizeNormal = 0;
            var stringList = StringsUtility.GenerateRandomStringList(numberOfStrings: 100, stringLength: 75, stringVariance: 25);

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Parallel.For(0, stringList.Count, i =>
            {
                Interlocked.Add(ref totalSizeParallel, stringList[i].Length);
            });
            stopwatch.Stop();

            var stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            stringList.ForEach(stringItem =>
            {
                totalSizeNormal += stringItem.Length;
            });
            stopwatch2.Stop();
            return Ok();
        }
    }
}
