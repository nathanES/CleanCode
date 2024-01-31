using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Facade.ExLivreDesignPatternCSharp;
//Informations : Design pattern Facade
//Le but du pattern Facade est de regrouper les interfaces d'un ensemble d'objets en une interface
//  unifiée rendant cet ensemble plus simple à utiliser pour un client.
//Le pattern Facade encapsule l'interface de chaque objet considérée comme interface de bas
//  niveau dans une interface unique de niveau plus élevé. La construction de l'interface unifiée
//  peut nécessiter d'implémanter des méthodes destinées à composer les interfaces de bas niveau.

//Le pattern est utilisé dans les domaines suivants:
//- Pour fournir une interface simple d'un système complexe. L'architecture d'un système
//  complexe. L'architecture d'un système complexe peut être basée sur de nombreuses petites
//  classes, lui offrant une modularité et des capacités d'évolution. Cependant, ces bonnes
//  propriétés du système n'intéressent pas ses clients qui ont besoin d'un accès simple qui
//  répond à leurs exigences
//- Pour diviser un système en sous-systèmes, la communication entre sous-systèmes étant mise
//  en oeuvre de façon abstraite de leur implémentation grâce aux facades.
//- Pour systématiser l'encapsulation de l'implémentation d'un système vis à vis de l'extérieur.

public class UtilisateurWebService
{
    public static void Main(string[] args)
    {
        IWebServiceAuto webServiceAuto = new WebServiceAutoImpl();
        Console.WriteLine(webServiceAuto.Document(0));
        Console.WriteLine(webServiceAuto.Document(1));
        IList<string> resultats = webServiceAuto.ChercheVehicules(6000, 1000);
        if (resultats.Count > 0)
        {
            Console.WriteLine("Véhicule(s) dont le prix est compris entre 5000 et 7000");
            foreach (string resultat in resultats)
            {
                Console.WriteLine("   " + resultat);
            }
        }
    }
    //Document numéro 0
    //Document numéro 1
    //Véhicule(s) dont le prix est compris entre 5000 et 7000
    //   Berline 5 portes
    //   Break 5 portes
    //   Utilitaire 3 portes
}
