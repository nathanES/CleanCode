namespace _20___State.ExLivreDesignPatternCSharp;
//Etat abstrait
public abstract class EtatCommande
{
    protected Commande commande;
    public EtatCommande(Commande commande)
    {
        this.commande = commande;
    }
    public abstract void AjouteProduit(Produit produit);
    public abstract void RetireProduit(Produit produit);
    public abstract void Efface();
    public abstract EtatCommande EtatSuivant();
}
