using Microsoft.AspNetCore.Mvc;

namespace Sandbox.Api.Modules.DesignPatterns.SingletonPattern
{
    public class SingletonPatternDemo : Controller
    {
        private SingletonClass? _singleton;
        public SingletonPatternDemo() 
        {
            InitializeSingleton();
        }

        
        public void InitializeSingleton()
        {
            // simulate a Main() method or program startup instance
            // program starts up..

            // initialize the singleton
            _singleton = new SingletonClass();

            _singleton.StoreName = "Test Store";
            _singleton.Categories = new List<SingletonCategory>() 
            { 
                new SingletonCategory() { Id = 1, Name = "Test Category 1", Description = "Test Description 1"},
                new SingletonCategory() { Id = 2, Name = "Test Category 2", Description = "Test Description 2"},
                new SingletonCategory() { Id = 3, Name = "Test Category 3", Description = "Test Description 3"}
            };

        }

        [HttpGet]
        public List<SingletonCategory> GetCategoriesFromSingleton()
        {
            if (_singleton?.Categories == null)
            {
                return new List<SingletonCategory>();
            }

            return _singleton.Categories;    
        }
    }
}
