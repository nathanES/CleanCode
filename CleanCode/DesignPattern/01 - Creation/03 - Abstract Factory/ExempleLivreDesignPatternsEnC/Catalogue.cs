namespace _03___Abstract_Factory.ExempleLivreDesignPatternsEnC;
public class Catalogue
{
  //Point d'entrée
  public static int nbVoiture = 3;
  public static int nbScooter = 2;

  private readonly IFabriqueVehicule fabrique;

  public Catalogue(IFabriqueVehicule fabrique)
  {
    this.fabrique = fabrique;
  }
  public void Main()
  {

    Automobile[] autos = new Automobile[nbVoiture];
    Scooter[] scooters = new Scooter[nbScooter];

    for (int i = 0; i < nbVoiture; i++)
      autos[i] = fabrique.CreeAutomobile("standard", "jaune", 6 + i, 3.2);
    for (int i = 0; i < nbScooter; i++)
      scooters[i] = fabrique.CreeScooter("classic", "rouge", 2 + i);
    foreach (Automobile auto in autos)
      auto.AfficheCaracteristiques();
    foreach (Scooter scooter in scooters)
      scooter.AfficheCaracteristiques();
  }
}
