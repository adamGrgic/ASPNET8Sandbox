namespace Sandbox.Api.Controllers.Linq.EnumerableMethods
{
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    static Pet[] GetCats()
    {
        Pet[] cats = { new Pet { Name="Barley", Age=8 },
                   new Pet { Name="Boots", Age=4 },
                   new Pet { Name="Whiskers", Age=1 } };
        return cats;
    }

    static Pet[] GetDogs()
    {
        Pet[] dogs = { new Pet { Name="Bounder", Age=3 },
                   new Pet { Name="Snoopy", Age=14 },
                   new Pet { Name="Fido", Age=9 } };
        return dogs;
    }
    public class Concat : Controller
    {

        constructor()
        {

        }


        public static void ConcatEx1()
        {
            Pet[] cats = GetCats();
            Pet[] dogs = GetDogs();

            IEnumerable<string> query =
                cats.Select(cat => cat.Name).Concat(dogs.Select(dog => dog.Name));

            foreach (string name in query)
            {
                Console.WriteLine(name);
            }
        }

    }
}
