namespace _20___State.ExLivreDesignPatternCSharp;
//Etat concret
public class CommandeValidee : EtatCommande
{
    public CommandeValidee(Commande commande) : base(commande)
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
        commande.Produits.Clear();
    }
    public override EtatCommande EtatSuivant()
    {
        return new CommandeLivree(commande);
    }
}
