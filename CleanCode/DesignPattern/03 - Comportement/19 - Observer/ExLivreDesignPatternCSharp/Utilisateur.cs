using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___Observer.ExLivreDesignPatternCSharp;

//Informations : Design pattern Observer
//Le but du pattern Observer est de constuire une dépendance entre un sujet
//  et des observateurs de sorte que chaque modification du sujet soit notifiée aux
//  observateurs afin qu'ils puissent mettre à jour leur état.

//Le pattern est utilisé dans les cas suivants:
//- Une modification dans l'état d'un objet engendre des modifications
//  dans d'autres objets qui sont déterminés dynamiquement.
//- Un objet veut prévenit d'autres objets sans devoir connaître leur type,
//  c-a-d sans être fortement couplé à ceux-ci.
//- On ne veut pas fusionner deux objets en un seul.

public class Utilisateur
{
    static void Main(string[] args)
    {
        Vehicule vehicule = new Vehicule();
        vehicule.Description = "Vehicule bon marché";
        vehicule.Prix = 5000;

        VueVehicule vueVehicule = new VueVehicule(vehicule);
        vueVehicule.Redessine();
        vehicule.Prix = 4500;

        VueVehicule vueVehicule2 = new VueVehicule(vehicule);
        vehicule.Prix = 5500;
    }
    // Sortie :
    // Description Vehicule bon marché prix : 5000
    // Description Vehicule bon marché prix : 4500
    // Description Vehicule bon marché prix : 5500
    // Description Vehicule bon marché prix : 5500
}
