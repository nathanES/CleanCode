namespace _02___FactoryMethod.ExempleLivreDesignPatternEnC;
//Informations : Design pattern FactoryMethod
//Le but du pattern FactoryMethod est d'introduire une méthode abstraite de création d'un objet en reportant
//    aux sous-classes concrètes la création effective
//Le pattern est utilisé dans les domaines suivants:
//  - Une classe ne connait que les classes abstraites des objets avec
//    lesquels elle possède des relations.
//  - Une classe veut transmettre à ses sous-classes les choix
//    d'instanciation.en profitant du mécanisme de polymorphisme

public class Utilisateur //Point d'entrée
{
    public static void Main()
    {
        Client client;
        client = new ClientComptant();
        client.nouvelleCommande(2000.0);
        client.nouvelleCommande(10000.0);
        client = new ClientCredit();
        client.nouvelleCommande(2000.0);
        client.nouvelleCommande(10000.0);
    }
}
