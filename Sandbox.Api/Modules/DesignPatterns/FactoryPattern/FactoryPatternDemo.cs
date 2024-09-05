using Microsoft.AspNetCore.Mvc;
using Sandbox.Api.Modules.DesignPatterns.FactoryPattern.SimpleFactoryComponents;
using Sandbox.Api.Modules.DesignPatterns.FactoryPattern.AdvancedShapeFactoryComponents;


namespace Sandbox.Api.Modules.DesignPatterns.FactoryPattern
{
    [Route("[controller]/[action]")]
    public class FactoryPatternDemo : Controller
    {
        // In this instance, we create one base interface: IShapeGeneratorSimple
        // Through this interface, we define one method: GenerateShapeSimple()
        // We don't define what this does in the interface, we just simply declare it as a method that can be used by classes that inherit the interface
        // We then create a SquareGenerator class that inherits this interface, which uses the GenerateSimpleShape method for its own criteria
        // This is the essence of creating a factory, we're creating an interface for a common set of objects (that are loosely related) which can then define
        // their own method from a common interface 
        [HttpGet]
        public IActionResult GenerateShapesFactoryBasic()
        {
            var shapesList = new List<string>()
            {
                new SquareGenerator().GenerateShapeSimple(),
                new CircleGenerator().GenerateShapeSimple(),
                new TriangleGenerator().GenerateShapeSimple()
            };
            
            return Ok(shapesList);
        }


        [HttpGet]
        public IActionResult GenerateShapesFactoryAdvanced()
        {
            var shapesList = new List<Shape>()
            {
                new AdvancedSquareGenerator().GenerateShape(),
                new AdvancedCircleGenerator().GenerateShape(),
                new AdvancedTriangleGenerator().GenerateShape()
            };

            return Ok(shapesList);
        }
    }
}
