namespace _04___Prototype.ExLivreDesignPatternCSharp;
public class DemandeImmatriculation : Document
{
    public override void affiche()
    {
        Console.WriteLine($"Demande d'immatriculation : {contenu}");
    }
    public override void imprime()
    {
        Console.WriteLine($"Impression de la demande d'immatriculation : {contenu}");
    }
}
