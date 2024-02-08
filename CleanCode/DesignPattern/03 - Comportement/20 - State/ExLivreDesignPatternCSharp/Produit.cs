namespace _20___State.ExLivreDesignPatternCSharp;
public class Produit
{
    protected string nom;
    public Produit(string nom)
    {
        this.nom = nom;
    }
    public void Affiche()
    {
        Console.WriteLine("Produit : " + nom);
    }
}
