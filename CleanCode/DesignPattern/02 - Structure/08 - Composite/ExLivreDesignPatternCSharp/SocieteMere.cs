using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___Composite.ExLivreDesignPatternCSharp;
//Composé
public class SocieteMere : Societe
{
    protected IList<Societe> filiales = new List<Societe>();

    public override bool AjouteFiliale(Societe filiale)
    {
        filiales.Add(filiale);
        return true;
    }

    public override double CalculeCoutEntretien()
    {
        double cout = 0.0;
        foreach (Societe filiale in filiales)
        {
            cout = cout + filiale.CalculeCoutEntretien();
        }
        return cout + nbrVehicules * coutUnitVehicule;
    }
}
