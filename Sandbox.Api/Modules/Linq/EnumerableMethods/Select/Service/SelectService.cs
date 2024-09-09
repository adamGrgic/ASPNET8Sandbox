using Sandbox.Api.SandboxUtils;

namespace Sandbox.Api.Modules.Linq.EnumerableMethods.Select.Service
{
    public class SelectService : ISelectService
    {
        public SelectService() 
        {
        }

        public bool SelectServiceV1()
        {
            var stringList = StringsUtility.GenerateRandomStringList(25, 75, 25);
            var stringListEvaluated = stringList.Select(x => x[0]);
            return true;
        }

    }
}
