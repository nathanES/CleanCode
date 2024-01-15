namespace _02___FactoryMethod.ExempleLivreDesignPatternEnC;
public class ClientCredit : Client
{
    protected override Commande creeCommande(double montant)
    {
        return new CommandeCredit(montant);
    }
}
