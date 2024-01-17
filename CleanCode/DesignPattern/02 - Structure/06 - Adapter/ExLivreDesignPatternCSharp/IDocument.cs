namespace _06___Adapter.ExLivreDesignPatternCSharp;
// Interface
public interface IDocument
{
    string Contenu { set; }
    void Dessine();
    void Imprime();
}
