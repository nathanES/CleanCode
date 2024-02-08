namespace _20___State.ExLivreDesignPatternCSharp;

//Informations : Design pattern State   
//Le but du pattern State est de permettre à un objet d'adapter son
//  comportement en fonction de son état interne.

//Le pattern est utilisé :
//- Le compoterment d'un objet dépend de son état
//- L'implémentation de cette dépendance à l'état par des instructions
//  conditionnelles est trop complexe.

public class Utilisateur
{
    public static void Run()
    {
        Commande commande = new();
        commande.AjouteProduit(new Produit("Vehicule 1"));
        commande.AjouteProduit(new Produit("Accessoire 2"));
        commande.Affiche();
        commande.EtatSuivant();
        commande.AjouteProduit(new Produit("Accessoire 3"));
        commande.Efface();
        commande.Affiche();

        Commande commande2 = new();
        commande2.AjouteProduit(new Produit("Vehicule 11"));
        commande2.AjouteProduit(new Produit("Accessoire 21"));
        commande2.Affiche();
        commande2.EtatSuivant();
        commande2.Affiche();
        commande2.EtatSuivant();
        commande2.Efface();
        commande2.Affiche();
    }
    //Contenu de la commande
    //Produit : Vehicule 1
    //Produit : Accessoire 2
    //
    //Contenu de la commande
    //
    //Contenu de la commande
    //Produit : Vehicule 11
    //Produit : Accessoire 21
    //
    //Contenu de la commande
    //Produit : Vehicule 11
    //Produit : Accessoire 21
    //
    //Contenu de la commande
    //Produit : Vehicule 11
    //Produit : Accessoire 21

}
