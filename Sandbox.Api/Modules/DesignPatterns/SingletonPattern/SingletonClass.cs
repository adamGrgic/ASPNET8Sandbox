namespace Sandbox.Api.Modules.DesignPatterns.SingletonPattern
{
    public class SingletonCategory()
    {
        public int Id { get; set; }
        required public string Name { get; set; }
        required public string Description { get; set; }
    }

    public class SingletonProduct() 
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        required public string Name { get; set; }
        required public string Description { get; set; }
    }

    // imagine in the following scenario you're creating an ecommerce platform and you need to store dynamic data set in 
    // an admin ui. 
    public sealed class SingletonClass
    {
        private static SingletonClass? _instance;
        public static SingletonClass Current => _instance ??= new
        SingletonClass();
        public string? StoreName { get; set; }
        public List<SingletonCategory>? Categories { get; set; }

    }

}
