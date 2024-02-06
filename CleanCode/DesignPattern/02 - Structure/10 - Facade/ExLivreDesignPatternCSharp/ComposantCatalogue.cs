using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Facade.ExLivreDesignPatternCSharp;
public class ComposantCatalogue : ICatalogue
{
protected object[] descriptionsVehicule = {
"Berline 5 portes", 6000,
"Compact 3 portes", 4000, 
"Espace 5 portes", 8000, 
"Break 5 portes" ,7000,
"Coupé 2 portes", 9000,
"Utilitaire 3 portes", 5000
};
    public IList<string> RetrouveVehicules(int prixMin, int prixMax)
    {
        int index, taille;
        IList<string> resultat = new List<string>();
        taille = descriptionsVehicule.Length / 2;
        for(index = 0; index < taille; index++)
        {
            int prix = (int)descriptionsVehicule[2 * index + 1];
            if ((prix >= prixMin) && (prix <= prixMax))
            {
                resultat.Add((string)descriptionsVehicule[2 * index]);
            }
        }
        return resultat;
    }
}
