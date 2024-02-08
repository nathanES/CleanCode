namespace _20___State.ExLivreDesignPatternCSharp;
//Etat concret
public class CommandeEnCours : EtatCommande
{
    public CommandeEnCours(Commande commande) : base(commande)
    {
    }
    public override void AjouteProduit(Produit produit)
    {
        commande.Produits.Add(produit);
    }
    public override void RetireProduit(Produit produit)
    {
        _ = commande.Produits.Remove(produit);
    }
    public override void Efface()
    {
        commande.Produits.Clear();
    }
    public override EtatCommande EtatSuivant()
    {
        return new CommandeValidee(commande);
    }
}
