using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Controllers.Linq.EnumerableMethods
{
    public class Count : Controller
    {
        public Count()
        {

        }

        public IActionResult BasicExample()
        {
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            try
            {
                int numberOfFruits = fruits.Count();
                Console.WriteLine(
                    "There are {0} fruits in the collection.",
                    numberOfFruits);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The count is too large to store as an Int32.");
                Console.WriteLine("Try using the LongCount() method instead.");
            }
        }
    }
}
