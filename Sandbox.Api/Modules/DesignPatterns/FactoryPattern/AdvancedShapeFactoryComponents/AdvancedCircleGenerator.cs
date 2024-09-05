using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DesignPatterns.FactoryPattern.AdvancedShapeFactoryComponents
{
    public class AdvancedCircleGenerator : IShapeGeneratorAdvanced
    {
        public Shape GenerateShape()
        {
            return new Shape() 
            { 
                Name = "Circle",
                Description = "A circle has no vertices and extends in 360 degrees.",
                Vertices = new List<Vertices>()
            };
        }
    }
}
