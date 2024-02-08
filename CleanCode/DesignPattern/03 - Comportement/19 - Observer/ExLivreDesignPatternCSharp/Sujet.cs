using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___Observer.ExLivreDesignPatternCSharp;
//Sujet
public abstract class Sujet
{
    protected List<IObservateur> observateurs = new List<IObservateur>();

    public void Ajoute(IObservateur observateur)
    {
        observateurs.Add(observateur);
    }

    public void Retire(IObservateur observateur)
    {
        observateurs.Remove(observateur);
    }

    public void Notifie()
    {
        foreach (IObservateur observateur in observateurs)
        {
            observateur.Actualise();
        }
    }
}
