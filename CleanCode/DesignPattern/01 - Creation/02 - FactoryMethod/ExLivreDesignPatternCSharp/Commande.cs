namespace _02___FactoryMethod.ExLivreDesignPatternCSharp;
public abstract class Commande
{
    protected double montant;
    public Commande(double montant)
    {
        this.montant = montant;
    }
    public abstract bool valide();
    public abstract void paye();
}
