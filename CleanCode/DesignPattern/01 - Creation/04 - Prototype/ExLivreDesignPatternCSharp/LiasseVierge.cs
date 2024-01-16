namespace _04___Prototype.ExLivreDesignPatternCSharp;
public class LiasseVierge : Liasse
{
    private static LiasseVierge? _instance = null;
    private LiasseVierge()
    {
        Documents = new List<Document>();
    }
    public static LiasseVierge Instance()
    {
        _instance ??= new LiasseVierge();
        return _instance;
    }
    public void ajoute(Document document)
    {
        Documents.Add(document);
    }
    public void retire(Document document)
    {
        _ = Documents.Remove(document);
    }
}
