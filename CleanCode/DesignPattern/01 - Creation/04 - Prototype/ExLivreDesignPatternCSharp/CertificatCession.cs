namespace _04___Prototype.ExLivreDesignPatternCSharp;
public class CertificatCession : Document
{
    public override void affiche()
    {
        Console.WriteLine($"Certificat de cession : {contenu}");
    }
    public override void imprime()
    {
        Console.WriteLine($"Impression du certificat de cession : {contenu}");
    }
}
