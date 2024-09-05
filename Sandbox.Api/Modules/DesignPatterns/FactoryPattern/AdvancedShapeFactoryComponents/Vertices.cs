namespace Sandbox.Api.Modules.DesignPatterns.FactoryPattern.AdvancedShapeFactoryComponents
{
    public struct Vertices
    {
        public int Point1 { get; set; }
        public int Point2 { get; set; }

        public Vertices(int point1, int point2)
        {
            Point1 = point1;
            Point2 = point2;
        }
    }
}
