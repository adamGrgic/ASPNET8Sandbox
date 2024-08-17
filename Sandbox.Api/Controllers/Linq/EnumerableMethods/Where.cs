using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Controllers.Linq.EnumerableMethods
{
    // https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-8.0
    public class Where : Controller
    {
        // Use this to help filter a sequence of values

        [HttpGet]
        public IActionResult V1()
        {
            var cars = new List<string>() { "Camry", "Focus", "Spider", "Cyber Truck", "M3" };

            var carsEval = cars.Where(car => car.Length < 6);

            return Ok(carsEval);
        }

        [HttpGet]
        public IActionResult V2()
        {
            var fishList = new List<string>() { "Salmon", "Tuna", "Mackeral", "Musky", "Yellow fin" };

            var fishEval = fishList.Where((fish, index) => fish.Length > index);

            return Ok(fishEval);
        }
    }
}
