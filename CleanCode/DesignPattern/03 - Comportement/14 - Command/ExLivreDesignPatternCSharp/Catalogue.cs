namespace _14___Command.ExLivreDesignPatternCSharp;
//Appelant
public class Catalogue
{
    protected IList<Vehicule> vehiculesStock = new List<Vehicule>();
    protected IList<CommandeSolder> commandes = new List<CommandeSolder>();
    public void LanceCommandeSolder(CommandeSolder commande)
    {
        commandes.Insert(0, commande);
        commande.Solde(vehiculesStock);
    }
    public void AnnuleCommandeSolder(int ordre)
    {
        commandes[ordre].Annule();
    }
    public void RetablitCommandeSolder(int ordre)
    {
        commandes[ordre].Retablit();
    }
    public void Ajoute(Vehicule vehicule)
    {
        vehiculesStock.Add(vehicule);
    }
    public void Affiche()
    {
        foreach (Vehicule vehicule in vehiculesStock)
        {
            vehicule.Affiche();
        }
    }
}
