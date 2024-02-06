namespace _14___Command.ExLivreDesignPatternCSharp;
//Recepteur
public class Vehicule
{
    protected string nom;
    protected long dateEntreeStock;
    protected double prixVente;
    public Vehicule(string nom, long dateEntreeStock, double prixVente)
    {
        this.nom = nom;
        this.dateEntreeStock = dateEntreeStock;
        this.prixVente = prixVente;
    }
    public long GetDuréeStockage(long aujourdhui)
    {
        return aujourdhui - dateEntreeStock;
    }
    public void ModifiePrix(double coefficient)
    {
        prixVente = 0.01 * Math.Round(coefficient * prixVente * 100);
    }
    public void Affiche()
    {
        Console.WriteLine(nom + " prix : " + prixVente + " date entrée Stock : " + dateEntreeStock);
    }
}
