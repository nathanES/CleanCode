namespace _06___Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Option 1 : Mieux
            var adapter = new PersonAdapter(new ExternalPersonAPIService());
            var person = adapter.GetPerson();
            Console.WriteLine($"{person.ID} {person.Name} {person.LastName}");

            //Option 2 : Moins bien
            var adapter2 = new ExternalPersonAdapter();
            var person2 = adapter.GetPerson();
            Console.WriteLine($"{person2.ID} {person2.Name} {person2.LastName}");
        }
    }
}