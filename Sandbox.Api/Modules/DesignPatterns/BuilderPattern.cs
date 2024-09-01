using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DesignPatterns
{
    public class Car
    {
        private readonly string _brand;
        private int carDoors;
        private bool withWifi;
        private bool withLeatherSeats;

        public Car(string brand) 
        {
            this._brand = brand;
        }


        public Car CarDoors(int carDoors)
        {
            this.carDoors = carDoors;
            return this;
        }

        public Car WithWifi(bool withWifi)
        {
            this.withWifi = withWifi;
            return this;
        }

        public Car WithLeatherSeats(bool withLeatherSeats)
        {
            this.withLeatherSeats = withLeatherSeats;
            return this;
        }
    }


    public class BuilderPattern : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
