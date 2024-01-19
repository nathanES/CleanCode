using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Composite.ExLivreDesignPatternCSharp;
//Composant
public abstract class Societe
{
    protected static double coutUnitVehicule = 5.0;
    protected int nbrVehicules;
    public void AjouteVehicule()
    {
        nbrVehicules = nbrVehicules + 1;
    }
    public abstract double CalculeCoutEntretien();
    public abstract bool AjouteFiliale(Societe filiale);
}
