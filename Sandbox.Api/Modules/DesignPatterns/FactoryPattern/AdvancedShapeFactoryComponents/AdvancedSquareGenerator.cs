using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DesignPatterns.FactoryPattern.AdvancedShapeFactoryComponents
{
    public class AdvancedSquareGenerator : IShapeGeneratorAdvanced
    {
        public Shape GenerateShape()
        {
            return new Shape() 
            { 
                Name ="Square", 
                Description="A square has 4 vertices that are even on all sides.",
                Vertices = new List<Vertices>
                {
                    new Vertices(1, 2),
                    new Vertices(2, 3),
                    new Vertices(3, 4),
                    new Vertices(4, 1)
                }
            };
        }
    }
}
