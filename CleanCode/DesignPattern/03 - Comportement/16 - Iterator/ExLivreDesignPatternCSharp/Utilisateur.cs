using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Iterator.ExLivreDesignPatternCSharp;

//Informations : Design pattern Iterator
//Le but du pattern Iterator est de fournir un accès séquentiel à une collection
//  d'objets à des clients sans que ceux-ci doivent se préoccuper de l'implémentation
//  de cette collection

//Le pattern est utilisé dans les domaines suivants:
//- Un parcours d'accès au vontenu d'une collection doit être réalisé sans accéder à la représentation interne de cette collection.
//- Il doit être possible de gérer plusieurs parcours simultanément.

public class Utilisateur
{
    static void Main(string[] args)
    {
        CatalogueVehicule catalogue = new CatalogueVehicule();
        IterateurVehicule iterateur = catalogue.Recherche("bon marché");
        Vehicule vehicule;
        iterateur.Debut();
        vehicule = iterateur.Item();
        while (vehicule != null)
        {
            vehicule.Affiche();
            iterateur.Suivant();
            vehicule = iterateur.Item();
        }
    }
    //Résultat
    //Description du vehicule : vehicule bon marché
    //Description du vehicule : petit vehicule bon marché
}
