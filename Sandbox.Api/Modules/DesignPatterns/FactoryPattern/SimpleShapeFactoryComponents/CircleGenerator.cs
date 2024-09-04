namespace Sandbox.Api.Modules.DesignPatterns.FactoryPattern.SimpleFactoryComponents
{
    public class CircleGenerator : IShapeGeneratorSimple
    {
        public string GenerateShapeSimple()
        {
            return "Circle";
        }

    }
}
