namespace _05___Builder.ExLivreDesignPatternCSharp;
//Produit (peut être abstrait ou concret)
public abstract class Liasse
{
    protected IList<string> contenu = new List<string>();
    public abstract void AjouteDocument(string document);
    public abstract void Imprime();
}
