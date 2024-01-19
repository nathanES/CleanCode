using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Composite.ExLivreDesignPatternCSharp;
//Informations : Design pattern Composite
//Le but du pattern Composite est d'offir un cadre de conception d'une d'une composition
//  d'objets dont la profondeur est variable, cette conception étant basée sur un arbre.
//Par ailleurs, cette composition est encapsulée vis-à-vis des clients des objets qui peuvent
//  interagir sans devoir connaître la profondeur de la composition.

//Le pattern est utilisé dans les domaines suivants:
//  - Il est nécessaire de représenter au sein d'un système des hiérarchies de composition
//  - Les clients d'une composition doivent ignorer s'ils communiquent avec des objets composés ou non.

public class Utilisateur // Point d'entrée
{
    static void main(string[] args)
    {
        Societe societe1 = new SocieteSansFiliale();
        societe1.AjouteVehicule();
        Societe societe2 = new SocieteSansFiliale();
        societe2.AjouteVehicule();
        societe2.AjouteVehicule();
        Societe groupe = new SocieteMere();
        groupe.AjouteFiliale(societe1);
        groupe.AjouteFiliale(societe2);
        groupe.AjouteVehicule();
        Console.WriteLine("Cout d'entretien total du groupe : " + groupe.CalculeCoutEntretien());//Cout d'entretien total du groupe : 20
    }
}
