namespace _23___Visitor.ExLivreDesignPatternCSharp;
//Element Concret
public class SocieteSansFiliale : Societe
{
    public SocieteSansFiliale(string nom, string email, string adresse) : base(nom, email, adresse)
    {
    }
    public override bool AjouteFiliale(Societe filiale)
    {
        return false;
    }
    public override void AccepteVisiteur(IVisiteur visiteur)
    {
        visiteur.Visite(this);
    }
}
