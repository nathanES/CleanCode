namespace _02___FactoryMethod.ExempleLivreDesignPatternEnC;
public abstract class Client
{
    protected List<Commande> commandes = new();
    protected abstract Commande creeCommande(double montant);
    public void nouvelleCommande(double montant)
    {
        Commande commande = creeCommande(montant);
        if (commande.valide())
        {
            commande.paye();
            commandes.Add(commande);
        }
    }
}
