namespace PrincipeL
{
    internal class Program
    {
        //Principe L : Liskov Substitution Principle
        //Si une méthode attend une classe de base,
        //si on l'appel avec une classe fille la méthode ne doit pas casser

        //Dans notre cas si on voulait faire une nouvelle forme mais quelle n'a pas de surface (une ligne par exemple)
        //On respecterait pas le principe L

        //Evolution : 
        //Pour avoir le même comportement dans la méthode SurfaceCalculator
        //  entre une Forme avec ou sans surface.
        //On a créé une classe ShapeWithSurface qui hérite de Shape et on fait hérité de toutes
        //  les formes qui ont une surface de celle ci.
        //On a modifier la SurfaceCalculator pour qu'elle ne prenne que les ShapeWithSurface
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}