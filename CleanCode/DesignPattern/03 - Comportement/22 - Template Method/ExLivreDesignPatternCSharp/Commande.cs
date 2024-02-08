namespace _22___Template_Method.ExLivreDesignPatternCSharp;
//Classe abstraite
public abstract class Commande
{
    protected double montantHt;
    protected double montantTva;
    protected double montantTtc;
    protected abstract void calculeTva();
    public void calculeMontantTtc()
    {
        calculeTva();
        montantTtc = montantHt + montantTva;
    }
    public void setMontantHt(double montantHt)
    {
        this.montantHt = montantHt;
    }
    public void affiche()
    {
        Console.WriteLine("Commande");
        Console.WriteLine("Montant HT " + montantHt);
        Console.WriteLine("Montant TTC " + montantTtc);
    }
}
