namespace _05___Builder.ExLivreDesignPatternCSharp;
public class LiassePdf : Liasse
{
    public override void AjouteDocument(string document)
    {
        if (document.StartsWith("<PDF>"))
        {
            contenu.Add(document);
        }
    }

    public override void Imprime()
    {
        Console.WriteLine("Liasse PDF");
        foreach (string s in contenu)
        {
            Console.WriteLine(s);
        }
    }
}
