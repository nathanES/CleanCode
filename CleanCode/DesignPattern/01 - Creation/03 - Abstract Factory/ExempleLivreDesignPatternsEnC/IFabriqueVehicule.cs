namespace _03___Abstract_Factory.ExempleLivreDesignPatternsEnC;
public interface IFabriqueVehicule
{
  Automobile CreeAutomobile(string modele, string couleur, int puissance, double espace);
  Scooter CreeScooter(string modele, string couleur, int puissance);
}
