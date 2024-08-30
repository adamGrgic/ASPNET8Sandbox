using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Controllers.MemoryManagement
{

    public class Product()
    {
        public required int Id { get; set; }
        public required string SKU { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
    }

    public readonly struct Dimension
    {
        public double Height { get; }
        public double Width { get; }
        public double Length { get; }

        public Dimension(double height, double width, double length)
        {
            Height = height;
            Width = width;
            Length = length;
        }
    }


    // for more information on memory management check out 
    // https://learn.microsoft.com/en-us/dotnet/standard/managed-code
    
    [Route("MemoryManagement/[action]")]
    public class MemoryManagementController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Use this space to show heap versus stack in action

            // Tina's Flower Shop
            // Imagine you are creating a web application for a flower shop 
            // The flower shop's website fits the mold of your standard ecommerce website



            // they have classes like Products, Inventory, Users, Accounts, Prices, etc, that are declared when the web application is started
            // ... needs more info 

            HeapVStackBasicExample();

            return Ok();
        }


        // start by declaring a new class, Product , and a new struct Dimension
        // observe what you see in the Locals and Autos window, especially when you exit the method
        private void HeapVStackBasicExample()
        {
            var flower = new Product()
            {
                Id = 1,
                SKU = "S-D1",
                Description = "Great for broken hearts",
                Name = "Daisy"
            };

            var dimension = new Dimension(1, 1, 1);
        }
    }
}
