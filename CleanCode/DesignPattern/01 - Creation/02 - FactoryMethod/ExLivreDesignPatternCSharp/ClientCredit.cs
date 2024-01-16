namespace _02___FactoryMethod.ExLivreDesignPatternCSharp;
public class ClientCredit : Client
{
    protected override Commande creeCommande(double montant)
    {
        return new CommandeCredit(montant);
    }
}
