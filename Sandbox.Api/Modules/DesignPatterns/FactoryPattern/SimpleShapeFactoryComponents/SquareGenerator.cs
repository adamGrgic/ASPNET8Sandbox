namespace Sandbox.Api.Modules.DesignPatterns.FactoryPattern.SimpleFactoryComponents
{
    public class SquareGenerator : IShapeGeneratorSimple
    {

        public string GenerateShapeSimple()
        {
            return "Square";
        }
    }
}
