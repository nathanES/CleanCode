using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___Memento.ExLivreDesignPatternCSharp;

//Informations : Design pattern Memento
//Le but du pattern Memento a pour but de sauvegarder et de restaurer l'état d'un objet
//  sans en violer l'encapsulation.

//Le pattern est utilisé dans le cas où l'état interne d'un objet (totalement ou en partie)
//  doit être mémorisé afin de pouvoir être restauré ultérieurement sans que l'encapsulation
//  de cet objet ne doive être brisée.

public class Utilisateur
{
    static void Main(string[] args)
    {
        IMemento memento;
        OptionVehicule option1 = new OptionVehicule("Sièges en cuir");
        OptionVehicule option2 = new OptionVehicule("Accoudoirs");
        OptionVehicule option3 = new OptionVehicule("Sièges sportifs");
        option1.AjouteOptionIncompatible(option3);
        option2.AjouteOptionIncompatible(option3);

        ChariotOption chariotOptions = new ChariotOption();
        chariotOptions.AjouteOption(option1);
        chariotOptions.AjouteOption(option2);
        chariotOptions.Affiche();

        memento = chariotOptions.AjouteOption(option3);
        chariotOptions.Affiche();

        chariotOptions.Annule(memento);
        chariotOptions.Affiche();
    }
    // Sortie :
    // Contenu du chariot des options
    // option : Sièges en cuir
    // option : Accoudoirs
    //
    // Contenu du chariot des options
    // option : Sièges Sportifs
    //
    // Contenu du chariot des options
    // option : Sièges en cuir
    // option : Accoudoirs
}
