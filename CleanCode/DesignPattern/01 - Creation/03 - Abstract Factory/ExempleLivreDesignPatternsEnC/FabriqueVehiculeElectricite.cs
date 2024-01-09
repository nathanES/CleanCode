namespace _03___Abstract_Factory.ExempleLivreDesignPatternsEnC;
public class FabriqueVehiculeElectricite : IFabriqueVehicule
{
  public Automobile CreeAutomobile(string modele, string couleur, int puissance, double espace)
  {
    return new AutomobileElectricite(modele, couleur, puissance, espace);
  }

  public Scooter CreeScooter(string modele, string couleur, int puissance)
  {
    return new ScooterElectricite(modele, couleur, puissance);
  }
}

