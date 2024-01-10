namespace _05___Builder.ExempleLivreDesignPatternsEnC;
public class LiasseHtml : Liasse
{
  public override void AjouteDocument(string document)
  {
    if (document.StartsWith("<HTML>"))
    {
      contenu.Add(document);
    }
  }

  public override void Imprime()
  {
    Console.WriteLine("Liasse HTML");
    foreach (string s in contenu)
    {
      Console.WriteLine(s);
    }
  }
}