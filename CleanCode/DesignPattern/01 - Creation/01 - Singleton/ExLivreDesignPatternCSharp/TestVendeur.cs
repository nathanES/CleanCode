namespace _01___Singleton.ExLivreDesignPatternCSharp;
//Informations : Design pattern Singleton
//Le but du pattern Singleton est d'assurer qu'une classe ne possède
//  qu'une seule instance et de fournir une méthode de classe unique retournant cette instance.
//Dans certans cas, il est utile de gérer des classes ne possédant qu'une seule instance.
//  Dans le cadre des patterns de construction, nous pouvons citer
//  le cas d'une fabrique de produits (pattern Abstract Factory) dont il n'est
//  pas nécessaire de créer plus d'une instance.

//Le pattern est utilisé dans les domaines suivants:
//  - Il ne doit y avoir qu'une seule instance d'une classe
//  - Cette instance ne doit être accessible qu'au travers d'une méthode de classe
public class TestVendeur // Point d'entrée
{
    private static void Main(string[] args)
    {
        Vendeur vendeur1 = Vendeur.Instance();
        vendeur1.Nom = "Dupont";
        vendeur1.Adresse = "Paris";
        vendeur1.Email = "vendeur@vendeur.com";
        Affiche();
    }

    private static void Affiche()
    {
        Vendeur vendeur = Vendeur.Instance();
        vendeur.affiche();
    }
}
