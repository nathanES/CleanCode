namespace _02___FactoryMethod.ExempleLivreDesignPatternEnC;
public class CommandeCredit : Commande
{
    public CommandeCredit(double montant) : base(montant)
    {
    }
    public override bool valide()
    {
        return montant is >= 1000.0 and <= 5000.0;
    }
    public override void paye()
    {
        Console.WriteLine("Le paiement de la commande au crédit de : " + montant + " est effectué.");
    }
}
