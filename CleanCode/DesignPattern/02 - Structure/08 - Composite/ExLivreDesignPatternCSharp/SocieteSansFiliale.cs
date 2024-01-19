using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Composite.ExLivreDesignPatternCSharp;
//Feuille
public class SocieteSansFiliale : Societe
{
    public override bool AjouteFiliale(Societe filiale)
    {
        return false;
    }

    public override double CalculeCoutEntretien()
    {
        return nbrVehicules * coutUnitVehicule;
    }
}
