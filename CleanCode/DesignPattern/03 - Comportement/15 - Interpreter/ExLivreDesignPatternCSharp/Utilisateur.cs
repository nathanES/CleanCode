namespace _15___Interpreter.ExLivreDesignPatternCSharp;

//Informations : Design pattern Interpreter
//Le but du pattern Inerpreter est de fournir un cadre pour donner
//  une représentation par objets de la grammaire d'un langage afin d'évaluer,
//  en les interprétant, des expressions écrites dans ce langage.

//Le pattern est utilisé pour interpréter des expressions représentées
//  sous la forme d'arbres syntaxiques. Il s'applique principalement dans les cas suivants :
//- La grammaire des expressions est simple.
//- L'évaluation n'a pas besoint d'être rapide.

public class Utilisateur
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entrez votre requête : ");
        string requete = Console.ReadLine();
        Expression expressionRequete;
        try
        {
            expressionRequete = Expression.Analyse(requete);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            expressionRequete = null;
        }
        if (expressionRequete != null)
        {
            Console.WriteLine("Entrez le texte de description d'un véhicule : ");
            string description = Console.ReadLine();
            if (expressionRequete.Evalue(description))
                Console.WriteLine("La description répond à la requête");
            else
                Console.WriteLine("La description ne répond pas à la requête");
        }
        //Entrez votre requête : (rouge ou gris) et récent et diesel
        //Entrez le texte de description d'un véhicule :
        //Ce véhicule rouge fonctionnant au diesel est récent
        //La description répond à la requête
    }
}
