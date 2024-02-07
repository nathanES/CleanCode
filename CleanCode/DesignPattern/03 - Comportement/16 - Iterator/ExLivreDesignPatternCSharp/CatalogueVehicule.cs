using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Iterator.ExLivreDesignPatternCSharp;
//Collection Concrète
public class CatalogueVehicule : Catalogue<Vehicule, IterateurVehicule>
{
    public CatalogueVehicule()
    { //Cela devrait provenir d'une base de données
        Contenu.Add(new Vehicule("vehicule bon marché"));
        Contenu.Add(new Vehicule("petit vehicule bon marché"));
        Contenu.Add(new Vehicule("vehicule grande qualité"));
    }
}
