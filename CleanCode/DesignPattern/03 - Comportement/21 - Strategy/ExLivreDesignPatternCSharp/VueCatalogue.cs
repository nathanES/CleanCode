namespace _21___Strategy.ExLivreDesignPatternCSharp;
public class VueCatalogue
{
    protected IList<VueVehicule> contenu = new List<VueVehicule>();
    protected IDessinCatalogue? dessin;
    public VueCatalogue(IDessinCatalogue dessin)
    {
        contenu.Add(new VueVehicule("vehicule bon marche"));
        contenu.Add(new VueVehicule("vehicule spacieux"));
        contenu.Add(new VueVehicule("vehicule rapide"));
        contenu.Add(new VueVehicule("vehicule confortable"));
        contenu.Add(new VueVehicule("vehicule sportif"));
        this.dessin = dessin;
    }
    public void Dessine()
    {
        dessin.Dessine(contenu);
    }
}
