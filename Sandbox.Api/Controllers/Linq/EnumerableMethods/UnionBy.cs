using Microsoft.AspNetCore.Mvc;
using System;

namespace Sandbox.Api.Controllers.Linq.EnumerableMethods
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    [Route("{controller}/{action}")]
    public class UnionBy : Controller
    {
        public UnionBy()
        {

        }

        public IActionResult V1()
        {
            var list1 = new List<Person>
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 }
                    };
            var list2 = new List<Person>
                    {
                new Person { Name = "Charlie", Age = 30 },
                new Person { Name = "Alice", Age = 40 }
            };

            // Use UnionBy to combine the lists based on the Name property.
            var unionByResult = list1.UnionBy(list2, person => person.Name);

            foreach (var person in unionByResult)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

            return Ok(unionByResult);

        }


    }
}
