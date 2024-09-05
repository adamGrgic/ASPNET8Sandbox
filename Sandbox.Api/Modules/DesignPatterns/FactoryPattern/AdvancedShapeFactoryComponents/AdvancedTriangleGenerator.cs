using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DesignPatterns.FactoryPattern.AdvancedShapeFactoryComponents
{
    public class AdvancedTriangleGenerator : IShapeGeneratorAdvanced
    {
        public Shape GenerateShape()
        {
            return new Shape() 
            { 
                Name="Triangle", 
                Description="A triangle has 3 vertices of varying length.",
                Vertices = new List<Vertices>
                {
                    new Vertices(1, 2),
                    new Vertices(2, 3),
                    new Vertices(3, 1)
                }
                    
                
            };
        }
    }
}
