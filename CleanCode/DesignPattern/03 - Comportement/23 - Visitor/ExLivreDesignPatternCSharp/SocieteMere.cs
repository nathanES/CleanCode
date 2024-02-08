namespace _23___Visitor.ExLivreDesignPatternCSharp;
//Element Concret
public class SocieteMere : Societe
{
    protected IList<Societe> filiales = new List<Societe>();
    public SocieteMere(string nom, string email, string adresse) : base(nom, email, adresse)
    {
    }
    public override bool AjouteFiliale(Societe filiale)
    {
        filiales.Add(filiale);
        return true;
    }
    public override void AccepteVisiteur(IVisiteur visiteur)
    {
        visiteur.Visite(this);
        foreach (Societe filiale in filiales)
        {
            filiale.AccepteVisiteur(visiteur);
        }
    }
}
