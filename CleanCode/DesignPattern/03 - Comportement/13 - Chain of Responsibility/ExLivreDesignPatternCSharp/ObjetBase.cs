using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Chain_of_Responsibility.ExLivreDesignPatternCSharp;
//Gestionnaire
public abstract class ObjetBase
{
    public ObjetBase Suivant { protected get; set; }
    private string DescriptionParDefaut()
    {
        return "Description par défaut";
    }
    protected abstract string Description { get; }
    public string DonneDescription()
    {
        string resultat = this.Description;
        if (resultat != null)
            return resultat;
        
        if(Suivant != null)
            return Suivant.DonneDescription();
        
        return DescriptionParDefaut();
    }
}
