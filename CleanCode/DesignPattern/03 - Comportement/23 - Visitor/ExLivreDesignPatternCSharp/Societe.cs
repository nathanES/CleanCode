namespace _23___Visitor.ExLivreDesignPatternCSharp;
//Element
public abstract class Societe
{
    public string Nom { get; protected set; }
    public string Email { get; protected set; }
    public string Adresse { get; protected set; }
    public Societe(string nom, string email, string adresse)
    {
        Nom = nom;
        Email = email;
        Adresse = adresse;
    }
    public abstract bool AjouteFiliale(Societe filiale);
    public abstract void AccepteVisiteur(IVisiteur visiteur);
}
