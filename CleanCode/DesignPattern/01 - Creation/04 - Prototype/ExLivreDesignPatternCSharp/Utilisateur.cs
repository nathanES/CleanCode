namespace _04___Prototype.ExLivreDesignPatternCSharp;
//Informations : Design pattern Prorotype
//Le but du pattern Prototype est la création de nouveaux objets par duplication d'objets
//  existants appelés prototypes qui disposent de la capacité de clonage.

//Le pattern est utilisé dans les domaines suivants:
//  - Un système d'objets doit créer des instancess sans connaître la hierrachie
//    des classes les décrivants.
//  - Un système d'objets doit créer des instances de classes chargées dynamiquement.
//  - Un système d'objets doit rester simple et ne pas inclure une hiérarchie
//    parallèle de classes de fabrique
public class Utilisateur //Point d'entrée
{
    private static void Main(string[] args)
    {
        LiasseVierge liasseVierge = LiasseVierge.Instance();
        liasseVierge.ajoute(new BonDeCommande());
        liasseVierge.ajoute(new CertificatCession());
        liasseVierge.ajoute(new DemandeImmatriculation());
        LiasseClient liasseClient1 = new("Martin");
        LiasseClient liasseClient2 = new("Durant");
        liasseClient1.affiche();
        liasseClient2.affiche();
        _ = Console.ReadKey();
    }
}
