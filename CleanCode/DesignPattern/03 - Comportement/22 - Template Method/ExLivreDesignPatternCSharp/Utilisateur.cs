namespace _22___Template_Method.ExLivreDesignPatternCSharp;

//Informations : Design pattern Template Method
//Le pattern Template Method permet de reporter dans des sous-classes
//  certaines étapes de l'une des opérations d'un objet, ces étapes étant
//  alors décrites dans les sous-classes.

//Le pattern est utilisé dans les cas suivants:
//- Une classe partage avec une ou plusieurs autres classes du code identique
//  qui peut être factorisé après que le ou les parties spécifiques à chaque classe
//  aient été déplacées dans de nouvelles méthodes.
//- Un algorithme possède une partie invariable et des parties spécifiques
//  à différents types d'objets.

public class Utilisateur
{
    private static void Main(string[] args)
    {
        Commande commandeFrance = new CommandeFrance();
        commandeFrance.setMontantHt(10000);
        commandeFrance.calculeMontantTtc();
        commandeFrance.affiche();

        Commande commandeLuxembourg = new CommandeLuxembourg();
        commandeLuxembourg.setMontantHt(10000);
        commandeLuxembourg.calculeMontantTtc();
        commandeLuxembourg.affiche();
    }
    //Résultat
    //Commande
    //Montant HT 10000
    //Montant TTC 12000
    //Commande
    //Montant HT 10000
    //Montant TTC 11700
}
