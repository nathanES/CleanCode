namespace _20___State.ExLivreDesignPatternCSharp;
//Etat concret
public class CommandeLivree : EtatCommande
{
    public CommandeLivree(Commande commande) : base(commande)
    {
    }
    public override void AjouteProduit(Produit produit)
    {
    }
    public override void RetireProduit(Produit produit)
    {
    }

    public override void Efface()
    {

    }
    public override EtatCommande EtatSuivant()
    {
        return this;
    }
}
