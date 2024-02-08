using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___Observer.ExLivreDesignPatternCSharp;
// Observateur concret
public class VueVehicule : IObservateur
{
    protected Vehicule vehicule;
    protected string texte = "";

    public VueVehicule(Vehicule vehicule)
    {
        this.vehicule = vehicule;
        this.vehicule.Ajoute(this);
        MetAJourTexte();
    }
    protected void MetAJourTexte()
    {
        texte = "Description " + vehicule.Description + " prix : " + vehicule.Prix;
    }
    public void Actualise()
    {
        MetAJourTexte();
        Redessine();
    }

    public void Redessine()
    {
        Console.WriteLine(texte);
    }
}
