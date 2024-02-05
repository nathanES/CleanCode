namespace _12___Proxy.ExLivreDesignPatternCSharp;
//Sujet Réel
public class Film : IAnimation
{
    public void Clic()
    {
    }

    public void Dessine()
    {
        Console.WriteLine("Affichage du film");
    }
    public void Charge()
    {
        Console.WriteLine("Chargement du film");
    }
    public void Joue()
    {
        Console.WriteLine("Lecture du film");
    }
}
