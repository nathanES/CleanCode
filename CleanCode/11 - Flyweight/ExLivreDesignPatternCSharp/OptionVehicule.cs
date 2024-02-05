namespace _11___Flyweight.ExLivreDesignPatternCSharp;
//Flyweight
public class OptionVehicule
{
    protected string nom;
    protected string description;
    protected int prixStandard;

    public OptionVehicule(string nom)
    {
        this.nom = nom;
        description = "Description de " + nom;
        prixStandard = 100;
    }

    public void Affiche(int prixDeVente)
    {
        Console.WriteLine("Option");
        Console.WriteLine("Nom : " + nom);
        Console.WriteLine(description);
        Console.WriteLine("Prix standard : " + prixStandard);
        Console.WriteLine("Prix de vente : " + prixDeVente);
    }
}
