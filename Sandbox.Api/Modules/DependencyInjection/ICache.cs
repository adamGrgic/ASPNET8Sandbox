namespace Sandbox.Api.Modules.DependencyInjection
{
    public interface ICache
    {
        object Get(string key);
    }
}
