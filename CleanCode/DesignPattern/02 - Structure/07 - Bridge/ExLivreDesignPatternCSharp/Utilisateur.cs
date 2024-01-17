namespace _07___Bridge.ExLivreDesignPatternCSharp;
//Informations : Design pattern Bridge
//Le but du pattern Bridge est de séparer l'aspect d'implantation d'un objet
//  de son aspect de représentation et d'interface.
//Ainsi, d'une part l'implantation peut être totalement encapsulée et d'autre part
//  l'implantation et la représentation peuvent évoluer indépendamment et sans que
//  l'une exerce une contrainte sur l'autre.

//Le pattern est utilisé dans les domaines suivants:
//  - Pour éviter une liaison forte entre la représentation des objets et leur
//    implantation, nottament quand l'implantation est sélectionnée au cours
//    de l'execution de l'application.
//  - Pour que les changements dans l'implantation des objets n'aient pas d'impact
//    dans les interractions entre les objets et leurs clients.
//  - Pour permettre à la représentation des objets et à leur implantation de conserver
//    leur capacité d'extension par la création de nouvelles sous-classes.
//  - Pour éviter d'obtenir des hiérarchies de classes extêmement complexes.
public class Utilisateur // Point d'entrée
{
    private static void main(string[] args)
    {
        FormulaireImmatriculationLux formulaire1 = new(new FormulaireHtmlImpl());
        formulaire1.Affiche();
        if (formulaire1.GereSaisie())
            formulaire1.GenereDocument();
        Console.WriteLine();

        FormulaireImmatriculationFrance formulaire2 = new(new FormulaireAppletImpl());
        formulaire2.Affiche();
        if (formulaire2.GereSaisie())
            formulaire2.GenereDocument();
        Console.WriteLine();
    }
}
