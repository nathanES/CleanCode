using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Iterator.ExLivreDesignPatternCSharp;
//Element Concret
public class Vehicule : Element
{
    public Vehicule(string description) : base(description)
    {
        
    }
    public void Affiche()
    {
        Console.WriteLine("Description du vehicule : " + Description);
    }

}
