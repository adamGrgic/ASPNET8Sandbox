using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Controllers.Linq.EnumerableMethods
{
    // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.chunk?view=net-8.0

    public class Chunk : ControllerBase
    {
        public Chunk() { }

        public IActionResult BasicExample()
        {
            var randomStringList = new List<string>() { "foo1", "foo2", "foo3", "foo4", "foo5", "foo6", "foo7", "foo8", "foo9" };

            var fooChunk = randomStringList.Chunk(4);

            return Ok();
        }
    }
}
