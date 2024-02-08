namespace _20___State.ExLivreDesignPatternCSharp;
//Machine à état
public class Commande
{
    protected IList<Produit> produits = new List<Produit>();
    public IList<Produit> Produits
    {
        get { return produits; }
    }

    protected EtatCommande etatCommande;
    public Commande()
    {
        etatCommande = new CommandeEnCours(this);
    }
    public void AjouteProduit(Produit produit)
    {
        etatCommande.AjouteProduit(produit);
    }
    public void RetireProduit(Produit produit)
    {
        etatCommande.RetireProduit(produit);
    }
    public void Efface()
    {
        etatCommande.Efface();
    }
    public void EtatSuivant()
    {
        etatCommande = etatCommande.EtatSuivant();
    }
    public void Affiche()
    {
        Console.WriteLine("Contenu de la commande");
        foreach (Produit produit in produits)
        {
            produit.Affiche();
        }
        Console.WriteLine();
    }
}
