namespace _05___Builder.ExLivreDesignPatternCSharp;
public abstract class Liasse
{
    protected IList<string> contenu = new List<string>();
    public abstract void AjouteDocument(string document);
    public abstract void Imprime();
}
