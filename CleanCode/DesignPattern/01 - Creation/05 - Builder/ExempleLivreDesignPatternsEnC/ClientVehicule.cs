namespace _05___Builder.ExempleLivreDesignPatternsEnC;

//Informations : Design pattern Builder
//Le but du pattern Builder est d'abstraire la construction d' objets complexes
//    de leur implémentation de sorte qu'un client puisse créer des objets complexes sans devoir
//    se préoccuper des différences d'implémentation.
//Le pattern est utilisé dans les domaines suivants:
//  - Un client a besoin de créer des objets complexes sans connaître les détails de leur implémentation.
//  - Un client a besoin de constuire des objeys complexes ayant plusieurs rerésentations ou implémentations.

public class ClientVehicule //Point d'entrée
{
    private static void Main(string[] args)
    {
        ConstructeurLiasseVehicule constructeur;
        Console.WriteLine(value: "Voulez-vous construire " +
             "des liasses HTML (1) ou PDF (2) :");
        string choix = Console.ReadLine();
        if (choix == "1")
        {
            constructeur = new ConstructeurLiasseVehiculeHtml();
        }
        else
        {
            constructeur = new ConstructeurLiasseVehiculePdf();
        }
        Vendeur vendeur = new(constructeur);
        Liasse liasse = vendeur.Construit("Martin");
        liasse.Imprime();
        _ = Console.ReadKey();
    }
}
