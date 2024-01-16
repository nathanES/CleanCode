namespace _03___Abstract_Factory.ExLivreDesignPatternCSharp;
public class FabriqueVehiculeEssence : IFabriqueVehicule
{
    public Automobile CreeAutomobile(string modele, string couleur, int puissance, double espace)
    {
        return new AutomobileEssence(modele, couleur, puissance, espace);
    }

    public Scooter CreeScooter(string modele, string couleur, int puissance)
    {
        return new ScooterEssence(modele, couleur, puissance);
    }
}