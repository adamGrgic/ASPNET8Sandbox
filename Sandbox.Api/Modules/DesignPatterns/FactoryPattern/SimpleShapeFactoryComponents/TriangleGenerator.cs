namespace Sandbox.Api.Modules.DesignPatterns.FactoryPattern.SimpleFactoryComponents
{
    public class TriangleGenerator : IShapeGeneratorSimple
    {
        public string GenerateShapeSimple()
        {
            return "Triangle";
        }
    }
}
