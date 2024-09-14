using Microsoft.AspNetCore.SignalR;

namespace Sandbox.Api.Modules.DependencyInjection
{
    public class MyHub : Hub
    {
        public void Method([FromKeyedServices("small")] ICache cache)
        {
            Console.WriteLine(cache.Get("signalr"));
        }
    }
}
