namespace _23___Visitor.ExLivreDesignPatternCSharp;

//Informations : Design pattern Visitor
//Le pattern Visitor construit une opération à réaliser sur les éléments
//  d'un ensemble d'objets. De nouvelles opérations peuvent ainsi être ajoutées
//  sans modifier les classes de ces objets.

//Le pattern est utilisé dans les cas suivants:
//- De nombreuses fonctionnalités doivent être ajoutées à un ensemble de classes
//  sans que ces ajouts viennent alourdir ces classes.
//- Un ensemble de classes possèdent une structure fixe et il est nécessaire de
//  leur adjoindre des fonctionnalités sans modifier leur interface.

public class Utilisateur
{
    private static void Main(string[] args)
    {
        Societe societe1 = new SocieteSansFiliale("societe1", "infosociete1.com", "rue de la societe 1");
        Societe societe2 = new SocieteSansFiliale("societe2", "infosociete2.com", "rue de la societe 2");
        Societe groupe1 = new SocieteMere("groupe1", "infogroupe1.com", "rue du groupe 1");
        _ = groupe1.AjouteFiliale(societe1);
        _ = groupe1.AjouteFiliale(societe2);

        Societe societe3 = new SocieteSansFiliale("societe3", "infosociete3.com", "rue de la societe 3");
        Societe groupe2 = new SocieteMere("groupe2", "infogroupe2.com", "rue du groupe 2");
        _ = groupe2.AjouteFiliale(groupe1);
        _ = groupe2.AjouteFiliale(societe3);
        groupe2.AccepteVisiteur(new VisiteurMailingCommercial());
    }
    //Résultat
    //Envoi d'un email à groupe2 adresse : infogroupe2.com
    //Proposition commerciale pour votre groupe
    //Impression d'un courrier à groupe2 adresse : rue du groupe2
    //Proposition commerciale pour votre groupe
    //Envoi d'un email à groupe1 adresse : infogroupe1.com
    //Proposition commerciale pour votre groupe
    //Impression d'un courrier à groupe1 adresse : rue du groupe 1
    //Proposition commerciale pour votre groupe
    //Envoi d'un email à societe1 adresse : infosociete1.com
    //Proposition commerciale pour votre société
    //Envoi d'un email à societe2 adresse : infosociete2.com
    //Proposition commerciale pour votre société
    //Envoi d'un email à societe3 adresse : infosociete3.com
    //Proposition commerciale pour votre société

}
