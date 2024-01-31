using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Decorator.ExLivreDesignPatternCSharp;
//Composant concret
internal class VueVehicule : ComposantGraphiqueVehicule
{
    public void Affiche()
    {
        Console.WriteLine("Affichage du véhicule");
    }
}
