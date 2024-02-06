using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Chain_of_Responsibility.ExLivreDesignPatternCSharp;

//Informations : Design pattern Chain of Responsibility
//Le but du pattern est de construire une chaîne d'objets telle que si un objet
//  de la chaîne ne peut pas répondre à une requête, il puisse la transmettre à son successeur
//  et ainsi de suite jusqu'à ce que l'un des objets de la chaîne y réponde.

//Le pattern est utilisé dans les domaines suivants:
//- Une chaîne d'objets gère une requête selon un ordre qui est défini dynamiquement.
//- La façon dont une chaîne d'objets gère une requête ne doit pas être connue de ses clients.

public class Utilisateur
{
    static void Main(string[] args)
    {
        ObjetBase vehicule1 = new Vehicule("Auto++ KT500 Vehicule d'occasion en bon état");
        Console.WriteLine(vehicule1.DonneDescription());

        ObjetBase modele1 = new Modele("KT400", "Le vehicule spacieux et confortable");
        ObjetBase vehicule2 = new Vehicule(null);
        vehicule2.Suivant = modele1;
        Console.WriteLine(vehicule2.DonneDescription());

        ObjetBase marque1 = new Marque("Auto++", "La marque des autos", "de grande qualité");
        ObjetBase modele2 = new Modele("KT700", null);
        modele2.Suivant = marque1;
        ObjetBase vehicule3 = new Vehicule(null);
        vehicule3.Suivant = modele2;
        Console.WriteLine(vehicule3.DonneDescription());

        ObjetBase vehicule4 = new Vehicule(null);
        Console.WriteLine(vehicule4.DonneDescription());
    }
    //Auto++ KT500 Vehicule d'occasion en bon état
    //Modèle KT400 : Le vehicule spacieux et confortable
    //Marque Auto++ : La marque des autos de grande qualité
    //Description par défaut
}
