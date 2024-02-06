namespace _14___Command.ExLivreDesignPatternCSharp;
//Informations : Design pattern Command
//Le but du pattern est de transformer une requête en un objet, facilitant des opérations
//  comme l'annulation, la mise en file d'attente, leur suivi.

//Le pattern est utilisé dans les domaines suivants:
//- Un objet doit être paramétré par un traitement à réaliser.
//  Dans le cas du pattern Command,c'est l'appelant qui est paramétré
//  par une commande qui contient la description d'un traitement à réaliser
//  sur un ou plusieurs récepteurs.
//- Les commandes doivent être stockées dans une file et pouvoir être exécutées
//  à un moment quelconque, éventuellement plusieurs fois.
//- Les commandes sont annulables.
//- Les commandes doivent être tracées dans un fichier de log.
//- Les commandes doivent être regroupées sous la forme d'une transaction.
//  Une transaction est un ensemble ordonné de commandes qui agissent sur
//  l'état d'un système et qui peuvent être annulées.
public class Utilisateur
{
    private static void Main(string[] args)
    {
        Vehicule vehicule1 = new("A01", 1, 1000.0);
        Vehicule vehicule2 = new("A11", 6, 2000.0);
        Vehicule vehicule3 = new("Z03", 2, 3000.0);

        Catalogue catalogue = new();
        catalogue.Ajoute(vehicule1);
        catalogue.Ajoute(vehicule2);
        catalogue.Ajoute(vehicule3);
        Console.WriteLine("Affichage du catalogue initial");
        catalogue.Affiche();

        CommandeSolder commandeSolder = new(10, 5, 0.1);
        catalogue.LanceCommandeSolder(commandeSolder);
        Console.WriteLine("Affichage du catalogue après exécution de la première commande");
        catalogue.Affiche();
        Console.WriteLine();

        CommandeSolder commandeSolder2 = new(10, 5, 0.5);
        catalogue.LanceCommandeSolder(commandeSolder2);
        Console.WriteLine("Affichage du catalogue après exécution de la seconde commande");
        catalogue.Affiche();
        Console.WriteLine();

        catalogue.AnnuleCommandeSolder(1);
        Console.WriteLine("Affichage du catalogue après annulation de la première commande");
        catalogue.Affiche();
        Console.WriteLine();

        catalogue.RetablitCommandeSolder(1);
        Console.WriteLine("Affichage du catalogue après rétablissement  la première commande");
        catalogue.Affiche();
        Console.WriteLine();
    }
    //Affichage du catalogue initial
    //A01 prix : 1000 date entrée Stock : 1
    //A11 prix : 2000 date entrée Stock : 6
    //Z03 prix : 3000 date entrée Stock : 2
    //
    //Affichage du catalogue après exécution de la première commande
    //A01 prix : 900 date entrée Stock : 1
    //A11 prix : 2000 date entrée Stock : 6
    //Z03 prix : 2700 date entrée Stock : 2
    //
    //Affichage du catalogue après exécution de la seconde commande
    //A01 prix : 450 date entrée Stock : 1
    //A11 prix : 2000 date entrée Stock : 6
    //Z03 prix : 1350 date entrée Stock : 2
    //
    //Affichage du catalogue après annulation de la première commande
    //A01 prix : 500 date entrée Stock : 1
    //A11 prix : 2000 date entrée Stock : 6
    //Z03 prix : 1500 date entrée Stock : 2
    //
    //Affichage du catalogue après rétablissement  la première commande
    //A01 prix : 450 date entrée Stock : 1
    //A11 prix : 2000 date entrée Stock : 6
    //Z03 prix : 1350 date entrée Stock : 2
}
