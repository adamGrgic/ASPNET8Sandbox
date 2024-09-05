namespace Sandbox.Api.Modules.DesignPatterns.FactoryPattern.AdvancedShapeFactoryComponents
{
    public class Shape
    {
        required public string Name { get; set; }
        
        required public string Description { get; set; }
        
        required public List<Vertices> Vertices { get; set; }


    }
}
