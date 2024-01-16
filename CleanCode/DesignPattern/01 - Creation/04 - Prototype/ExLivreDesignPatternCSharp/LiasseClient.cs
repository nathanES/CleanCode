namespace _04___Prototype.ExLivreDesignPatternCSharp;
public class LiasseClient : Liasse
{
    public LiasseClient(string informations)
    {
        Documents = new List<Document>();
        LiasseVierge liasseVierge = LiasseVierge.Instance();
        IList<Document> documentsVierges = liasseVierge.Documents;
        foreach (Document document in documentsVierges)
        {
            Document copieDocument = document.Duplique();
            copieDocument.remplit(informations);
            Documents.Add(copieDocument);
        }
    }
    public void affiche()
    {
        foreach (Document document in Documents)
        {
            document.affiche();
        }
    }
    public void imprime()
    {
        foreach (Document document in Documents)
        {
            document.imprime();
        }
    }
}
