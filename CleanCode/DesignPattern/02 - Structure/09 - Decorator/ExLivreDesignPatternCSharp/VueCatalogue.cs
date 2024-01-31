using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Decorator.ExLivreDesignPatternCSharp;
//Informations : Design pattern Decorator
//Le but du pattern Decorator est d'ajouter dynamiquement des fonctionnalités à un objet.
//Cet ajout de fonctionnalités ne modifie pas l'interface de l'objet et reste donc transparent pour le client.
//Le pattern Decorator constitue une alternative par rapport à la création de sous-classes pour enrichir un objet.

//Le pattern est utilisé dans les domaines suivants:
//- Un système ajoute dynamiquement des fonctionnalités à un objet, sans modifier son interface,
//    c'est-à-dire sans que les clients de cet objet doivent être modifiés.
//- Un système gère des fonctionnalités qui peuvent être retirées dynamiquement.
//- L'utilisation de l'héritage pour étendre des objets n'est pas pratique,
//ce qui peut arriver quand leur hierarchie est déjà complexe.
public class VueCatalogue //Point d'entrée
{
    static void Main(string[] args)
    {
        VueVehicule vueVehicule = new VueVehicule();
        ModeleDecorateur modeleDecorateur = new ModeleDecorateur(vueVehicule);
        MarqueDecorateur marqueDecorateur = new MarqueDecorateur(modeleDecorateur);
        marqueDecorateur.Affiche();
    }
    //Affichage du véhicule
    //Informations techniques du modèle
    //Logo de la marque
}
