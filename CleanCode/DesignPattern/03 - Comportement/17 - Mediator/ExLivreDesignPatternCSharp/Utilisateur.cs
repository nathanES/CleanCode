using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Mediator.ExLivreDesignPatternCSharp;

//Informations : Design pattern Mediator
//Le but du pattern Mediator est la création d'un objet dont la vocation
//  est la gestion et le contrôle des interractions dans un ensemble d'objets
//  sans que ses éléments doivent se connaître mutuellement.

//Le pattern est utilisé dans les domaines suivants:
//- Un système est formé d'un ensemble d'objets basé sur une communication complexe conduisant
//  à associer de nombreux objets entre eux.
//- Les objets d'un système sont difficiles à réutiliser car ils possèdent de nombreuses
//  associations avec d'autres objets.
//- La modularité d'un système est médiocre, obligeant dans le cas d'une adaptation d'une partie du système à écrire de nombreuses sous classes.

public class Utilisateur
{
    static void Main(string[] args)
    {
        Formulaire formulaire = new Formulaire();
        formulaire.AjouteControle(new ZoneSaisie("Nom"));
        formulaire.AjouteControle(new ZoneSaisie("Prenom"));
        PopupMenu menu = new PopupMenu("Coemprunteur");
        menu.AjouteOption("sans coemprunteur");
        menu.AjouteOption("avec coemprunteur");
        formulaire.AjouteControle(menu);
        formulaire.MenuCoemprunteur = menu;
        Bouton bouton = new Bouton("OK");
        formulaire.AjouteControle(bouton);
        formulaire.BoutonOK = bouton;
        formulaire.AjouteControleCoemprunteur(new ZoneSaisie("Nom du coemprunteur"));
        formulaire.AjouteControleCoemprunteur(new ZoneSaisie("Prenom du coemprunteur"));
        formulaire.Saisie();
    }
    //Résultat
    //Saisie de : Nom
    // => Martin
    //Saisie de : Prenom
    // => Jean
    //Saisie de : Coemprunteur
    //Valeur actuelle :
    // - 0 )sans coemprunteur
    // - 1 )avec coemprunteur
    // => 1
    //Saisie de : Nom du coemprunteur
    // => Dupont
    //Saisie de : Prenom du coemprunteur
    // => Henri
    //Desirez-vous activer le bouton OK?
    // => oui
}
