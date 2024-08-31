using Microsoft.AspNetCore.Mvc;
using Sandbox.Api.Controllers.Linq.EnumerableMethods;

namespace Sandbox.Api.Modules.Linq.EnumerableMethods
{
    public class DefaultIfEmpty : Controller
    {
        public static void DefaultIfEmptyEx1()
        {
            List<Pet> pets =
                new List<Pet>{ new Pet { Name="Barley", Age=8 },
                       new Pet { Name="Boots", Age=4 },
                       new Pet { Name="Whiskers", Age=1 } };

            foreach (Pet pet in pets.DefaultIfEmpty())
            {
                Console.WriteLine(pet.Name);
            }
        }

    }
}
