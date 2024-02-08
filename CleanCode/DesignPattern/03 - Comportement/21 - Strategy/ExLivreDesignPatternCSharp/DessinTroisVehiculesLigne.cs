namespace _21___Strategy.ExLivreDesignPatternCSharp;
//Strategie Concret
public class DessinTroisVehiculesLigne : IDessinCatalogue
{
    public void Dessine(IList<VueVehicule> contenu)
    {
        Console.WriteLine("Dessin les véhicules avec trois véhicules par ligne");
        int i = 1;
        foreach (VueVehicule vueVehicule in contenu)
        {
            vueVehicule.Dessine();
            if (i++ % 3 == 0)
                Console.WriteLine();
            else
                Console.Write(" ");
        }
        if (i != 0)
            Console.WriteLine();
        Console.WriteLine();
    }
}
