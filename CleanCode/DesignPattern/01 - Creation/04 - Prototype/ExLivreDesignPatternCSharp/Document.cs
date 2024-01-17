namespace _04___Prototype.ExLivreDesignPatternCSharp;
//Prototype
public abstract class Document
{
    protected string contenu = "";
    public Document Duplique()
    {
        Document resultat;
        //Permet de dupliquer un objet sans avoir à assigner chaque propriétés
        resultat = (Document)MemberwiseClone();
        return resultat;
    }
    public void remplit(string informations)
    {
        contenu = informations;
    }
    public abstract void imprime();
    public abstract void affiche();
}
