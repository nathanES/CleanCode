using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Chain_of_Responsibility.ExLivreDesignPatternCSharp;
//Gestionnaire concret 2
public class Modele : ObjetBase
{
    protected string nom;
    protected string laDescription;
    public Modele(string nom, string description)
    {
        this.laDescription = description;
        this.nom = nom;
    }
    protected override string Description
    {
        get
        {
            if (laDescription != null)
                return "Modèle " + nom + " : " + laDescription;
            else
                return null;
        }
    }
}
