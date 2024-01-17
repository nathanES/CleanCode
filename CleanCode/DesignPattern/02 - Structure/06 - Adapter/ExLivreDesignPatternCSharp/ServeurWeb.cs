namespace _06___Adapter.ExLivreDesignPatternCSharp;
//Informations : Design pattern Adapter
//Le but du pattern Adapter est de convertir l'interface d'une classe existante
//  en l'interface attendue par des clients également existants afin qu'ils puissent
//  travailler ensemble.
//  Il s'agit de conférer à une classe existante une nouvelle interface pour répondre
//  aux besoins de clients.

//Le pattern est utilisé dans les domaines suivants:
//  - Pour intégrer dans un système un objet dont l'interface ne correspond pas
//    à l'interface requise au sein de ce système.
//  - Pour fournir des interfaces multiples à un objet lors de sa conception.

//Client
public class ServeurWeb // Point d'entrée
{
    private static void main(string[] args)
    {
        IDocument document1 = new DocumentHtml
        {
            Contenu = "Hello"
        };
        document1.Dessine();
        Console.WriteLine();
        IDocument document2 = new DocumentPdf
        {
            Contenu = "Bonjour"
        };
        document2.Dessine();
        Console.WriteLine();
    }
}
