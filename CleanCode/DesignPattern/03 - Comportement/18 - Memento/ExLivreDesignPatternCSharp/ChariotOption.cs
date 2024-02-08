using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___Memento.ExLivreDesignPatternCSharp;
//Objet origine
public class ChariotOption
{
    protected IList<OptionVehicule> options = new List<OptionVehicule>();
    public IMemento AjouteOption(OptionVehicule optionVehicule)
    {
        MementoImpl resultat = new MementoImpl();
        resultat.Etat = options;
        IList<OptionVehicule> optionsIncompatibles = new List<OptionVehicule>();
        foreach (OptionVehicule option in optionsIncompatibles)
        {
            options.Remove(option);
        }
        options.Add(optionVehicule);
        return resultat;
    }

    public void Annule(IMemento memento)
    {
        MementoImpl mementoImplInstance = memento as MementoImpl;
        if (mementoImplInstance != null)
        {
            options = mementoImplInstance.Etat;
        }
    }

    public void Affiche()
    {
        Console.WriteLine("Contenu du chariot des options");
        foreach (OptionVehicule option in options)
        {
            option.Affiche();
        }
        Console.WriteLine();
    }
}
