namespace _04___Prototype
{
    internal class Program
    {
        // Prototype permet de créer des clones d'objets
        static void Main(string[] args)
        {
            #region Methode 1 avec des classes 
            var personne = new Personne("Nathan");
            var chien = new Chien("Fanfan", personne);
            Console.WriteLine("Nom du chien 1 : " + chien.Nom);
            Console.WriteLine("Nom du propriétaire chien 1 : " + chien.Proprietaire.Nom);

            var chienClone = (Chien)chien.Clone();
            personne.Nom = "Nat";
            Console.WriteLine("Nom du chien 2 : " + chienClone.Nom);
            Console.WriteLine("Nom du propriétaire chien 2 : " + chienClone.Proprietaire.Nom);
            Console.WriteLine("Personne égale ? " + object.ReferenceEquals(personne,chienClone.Proprietaire));
            #endregion
            #region Methode 2 avec des Records
            var personne2 = new Personne2("Nathan");
            var chien2 = new Chien2("Fanfan", personne2);
            Console.WriteLine("Nom du chien record 1 : " + chien2.Nom);
            Console.WriteLine("Nom du propriétaire chien record 1 : " + chien2.Proprietaire.Nom);

            var chienClone2 = chien2 with { };
            personne2.Nom = "Nat";
            Console.WriteLine("Nom du chien record 2 : " + chienClone2.Nom);
            Console.WriteLine("Nom du propriétaire chien record 2 : " + chienClone2.Proprietaire.Nom);
            Console.WriteLine("Personne record égale ? " + object.ReferenceEquals(personne2, chienClone2.Proprietaire));
            #endregion
        }
    }
}