namespace _02___FactoryMethod.ExempleLivreDesignPatternEnC;
public class ClientComptant : Client
{
    protected override Commande creeCommande(double montant)
    {
        return new CommandeComptant(montant);
    }
}
