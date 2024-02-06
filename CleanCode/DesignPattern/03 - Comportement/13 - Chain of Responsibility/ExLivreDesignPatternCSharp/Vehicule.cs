using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Chain_of_Responsibility.ExLivreDesignPatternCSharp;
//Gestionnaire concret 1
public class Vehicule : ObjetBase
{
    protected string LaDescription;
    public Vehicule(string description)
    {
        LaDescription = description;
    }
    protected override string Description
    {
        get
        {
            return LaDescription;
        }
    }
}
