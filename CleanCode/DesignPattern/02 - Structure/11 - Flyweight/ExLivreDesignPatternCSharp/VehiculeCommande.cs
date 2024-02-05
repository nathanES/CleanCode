namespace _11___Flyweight.ExLivreDesignPatternCSharp;
//Informations : Design pattern Flyweight
//Le but du pattern Flyweight est de partager de façon efficace un ensemble d'objets de grain fin.

//Le pattern est utilisé dans les domaines suivants:
//- Le système utilise un grand nombre d'objets.
//- Le stockage des objets est coûteux à cause d'une grande quantité d'objets.
//- Il existe de nombreux ensembles d'objets qui peuvent être remplacés par quelques objets partagés
//  une fois qu'une partie de leur état est rendue extrinsèque.
public class VehiculeCommande
{
    protected IList<OptionVehicule> options = new List<OptionVehicule>();
    protected IList<int> prixDeVenteOptions = new List<int>();
    public void AjouteOption(string nom, int prixDeVente, FabriqueOption fabrique)
    {
        options.Add(fabrique.GetOption(nom));
        prixDeVenteOptions.Add(prixDeVente);
    }
    public void AfficheOptions()
    {
        int index, taille;
        taille = options.Count;
        for (index = 0; index < taille; index++)
        {
            options[index].Affiche(prixDeVenteOptions[index]);
            Console.WriteLine();
        }
    }
    //Option
    //Nom : airbag
    //Description de airbag
    //Prix standard : 100
    //Prix de vente : 80
    //
    //Option
    //Nom : direction assistée
    //Description de direction assistée
    //Prix standard : 100
    //Prix de vente : 90
    //
    //Option
    //Nom : vitres électriques
    //Description de vitres électriques
    //Prix standard : 100
    //Prix de vente : 85
}
