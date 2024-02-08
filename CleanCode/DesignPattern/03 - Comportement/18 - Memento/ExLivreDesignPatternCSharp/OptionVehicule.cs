using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___Memento.ExLivreDesignPatternCSharp;
public class OptionVehicule
{
    protected string nom;
    public IList<OptionVehicule> OptionsIncompatibles { get; protected set; }

    public OptionVehicule(string nom)
    {
        this.nom = nom;
        OptionsIncompatibles = new List<OptionVehicule>();
    }

    public void AjouteOptionIncompatible(OptionVehicule optionIncompatible)
    {
        if (!OptionsIncompatibles.Contains(optionIncompatible))
        {
            OptionsIncompatibles.Add(optionIncompatible);
            optionIncompatible.AjouteOptionIncompatible(this);
        }
    }

    public void Affiche()
    {
        Console.WriteLine("option : " + nom);
    }
}
