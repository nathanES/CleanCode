namespace _03___Abstract_Factory.ExLivreDesignPatternCSharp;

//Information : Design Pattern Abstract Factory
//Le but du pattern Abstract Factory est la création d'objets regroupés en familles
//    sans devoir connaitre les classes concrètes déstinées à la création de ces objets.
//Le pattern est utilisé dans les domaines suivants :
//  - Un système utilisant des produits a besoin d'être indépendant de la façon dont ces
//  produits sont créés et regroupés.
//  - Un système est paramétré par plusieurs familles de produits qui peuvent évoluer
public class Catalogue //Point d'entrée
{
    public static int nbVoiture = 3;
    public static int nbScooter = 2;

    private readonly IFabriqueVehicule fabrique; //En fonction de la fabrique, on aura des véhicules essence ou électrique

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
