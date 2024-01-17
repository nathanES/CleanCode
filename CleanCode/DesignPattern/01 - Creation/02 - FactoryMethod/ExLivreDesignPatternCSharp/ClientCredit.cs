namespace _02___FactoryMethod.ExLivreDesignPatternCSharp;
//Créateur concret
public class ClientCredit : Client
{
    protected override Commande creeCommande(double montant)
    {
        return new CommandeCredit(montant);
    }
}
