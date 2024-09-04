using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DesignPatterns.BuilderPattern
{
    // A builder patterns creates different representations of the same object

    // A common example of this would be building a house
    // House as a concept is a widely understood to many people but not all houses are built the same
    // for instance, some houses will have 2 rooms, others will have 4 rooms
    // some might have a washer and dryer included, others will not 

    // in the following scenario, imagine you're creating a web application where you want a user to 
    // determine how they want their house constructed 

    // in this scenario, a user would have a form on the front end where they can input values for different properties (ex: floors, rooms, bathrooms, etc)
    // 1/ Define the data model 
    // 2/ Create a class that instantiates the data model using a builder class
    // would probably look something like this:
    // 


    public class Floor
    {
        public int FloorNumber { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

    }

    public class Room
    {
        public required string Name { get; set; }
        public required string Flooring { get; set; }
        public string? Description { get; set; }
        public required int FloorNumber { get; set; }
        public required int Length { get; set; }
        public required int Height { get; set; }
        public required int Width { get; set; }
    }

    public class House
    {
        public int Id { get; set; }
        public List<Floor>? Floors { get; set; }
        public List<Room>? Rooms { get; set; }
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public bool HasWifi { get; set; }
        public bool HasWasherAndDryer { get; set; }


        public House AddFloors(List<Floor> floors)
        {
            Floors = floors;
            return this;
        }


        public House AddDimensions(int width, int height, int length)
        {
            Width = width;
            Height = height;
            Length = length;

            return this;
        }

        public House AddWifi(bool hasWifi)
        {
            HasWifi = hasWifi;
            return this;
        }

        public House AddWasherAndDryer(bool hasWasherAndDryer)
        {
            HasWasherAndDryer = hasWasherAndDryer;
            return this;
        }

        public House AddRooms(List<Room> rooms)
        {
            Rooms = rooms;
            return this;
        }


    }

    [ApiController]
    [Route("BuildPatternModule/[controller]")]
    public class SampleHouseBuilder : ControllerBase
    {
        public SampleHouseBuilder() { }


        [HttpGet]
        public IActionResult BuildHouse()
        {
            var rooms = new List<Room>
            {
                new Room() { Name = "Foo Room", FloorNumber = 1, Flooring = "wood", Description = "Its a Foo Room!", Height = 72, Length = 64, Width = 112 },
                new Room() { Name = "Dog Room", FloorNumber = 1, Flooring = "carpet", Description = "Its a Dog Room!", Height = 114, Length = 72, Width = 196 },
                new Room() { Name = "Bar Room", FloorNumber = 1, Flooring = "wood", Description = "Its a Bar Room!", Height = 45, Length = 78, Width = 156 },
                new Room() { Name = "Foo2 Room", FloorNumber = 2, Flooring = "wood", Description = "Its a Foo Room!", Height = 72, Length = 64, Width = 112 },
                new Room() { Name = "Dog2 Room", FloorNumber = 2, Flooring = "carpet", Description = "Its a Dog Room!", Height = 114, Length = 72, Width = 196 },
                new Room() { Name = "Bar2 Room", FloorNumber = 2, Flooring = "wood", Description = "Its a Bar Room!", Height = 45, Length = 78, Width = 156 }
            };

            var floors = new List<Floor>
            {
                new Floor() { FloorNumber = 1, Width = 276, Height = 96, Length = 134 },
                new Floor() { FloorNumber = 2, Width = 276, Height = 96, Length = 134 }
            };

            var house = new House()
                .AddFloors(floors)
                .AddRooms(rooms)
                .AddWifi(true)
                .AddWasherAndDryer(true)
                .AddDimensions(500, 500, 500);

            return Ok(house);
        }
    }

    public interface IHouseBuilder
    {
        public void BuildRooms();
        public void BuildFloors();
        public void HasNetworkConnectivity();
        public void HasWoodFlooring();
    }


    // very simple example
    public class Car
    {
        private readonly string _brand;
        private int carDoors;
        private bool withWifi;
        private bool withLeatherSeats;

        public Car(string brand)
        {
            _brand = brand;
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


    public class BuilderPatternDirector : Controller
    {
        public IActionResult BuildCar()
        {
            var car = new Car("toyota")
                .CarDoors(4)
                .WithLeatherSeats(true)
                .WithWifi(true);

            return Ok(car);
        }
    }
}
