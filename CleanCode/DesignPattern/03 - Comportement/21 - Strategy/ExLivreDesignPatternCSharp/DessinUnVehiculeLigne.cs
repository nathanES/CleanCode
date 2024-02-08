namespace _21___Strategy.ExLivreDesignPatternCSharp;
//Strategie Concret
public class DessinUnVehiculeLigne : IDessinCatalogue
{
    public void Dessine(IList<VueVehicule> contenu)
    {
        Console.WriteLine("Dessin les véhicules avec un véhicules par ligne");
        foreach (VueVehicule vueVehicule in contenu)
        {
            vueVehicule.Dessine();
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
