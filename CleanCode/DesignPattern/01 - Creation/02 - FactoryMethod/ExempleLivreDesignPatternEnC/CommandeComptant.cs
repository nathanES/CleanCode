namespace _02___FactoryMethod.ExempleLivreDesignPatternEnC;
public class CommandeComptant : Commande
{
    public CommandeComptant(double montant) : base(montant)
    {
    }
    public override bool valide()
    {
        return true;
    }
    public override void paye()
    {
        Console.WriteLine("Le paiement de la commande au comptant de : " + montant + " est effectué.");
    }
}
