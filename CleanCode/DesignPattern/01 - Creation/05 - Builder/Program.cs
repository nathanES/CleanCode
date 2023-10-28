namespace _05___Builder
{
    internal class Program
    {
        //Ce design pattern est très pratique lorsque l'on a une succession d'instructions de construction d'objets complexes
        //et on va avoir différentes variantes en fonction des règles business
        // On aura un directeur (BorneDeVente) qui connait les instructions à faire pour créer les objets
        static void Main(string[] args)
        {
            var borne = new BorneDeVente();

            var reineBuilder = new ReineBuilder();
            borne.PreparerPizza(reineBuilder);
            Console.WriteLine(reineBuilder.Pizza);

            var chevreMiel = new ChevreMielBuilder();
            borne.PreparerPizza(chevreMiel);
            Console.WriteLine(chevreMiel.Pizza);
        }
    }
}