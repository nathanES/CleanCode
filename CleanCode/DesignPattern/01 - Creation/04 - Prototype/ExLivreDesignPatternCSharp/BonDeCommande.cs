namespace _04___Prototype.ExLivreDesignPatternCSharp;
//Prototype concret
public class BonDeCommande : Document
{
    public override void affiche()
    {
        Console.WriteLine($"Bon de commande : {contenu}");
    }
    public override void imprime()
    {
        Console.WriteLine($"Impression du bon de commande : {contenu}");
    }
}
