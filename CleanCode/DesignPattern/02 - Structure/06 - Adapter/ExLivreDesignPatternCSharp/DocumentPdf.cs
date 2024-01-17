namespace _06___Adapter.ExLivreDesignPatternCSharp;
// Adapteur
public class DocumentPdf : IDocument
{
    protected ComposantPdf outilPdf = new();
    public string Contenu
    {
        set
        {
            outilPdf.PdfFixeContenu(value);
        }
    }

    public void Dessine()
    {
        outilPdf.PdfPrepareAffichage();
        outilPdf.PdfRafraichit();
        outilPdf.PdfTermineAffichage();
    }

    public void Imprime()
    {
        outilPdf.PdfEnvoieImprimante();
    }
}
