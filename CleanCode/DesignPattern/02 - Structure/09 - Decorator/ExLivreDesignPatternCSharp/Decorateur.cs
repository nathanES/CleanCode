using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Decorator.ExLivreDesignPatternCSharp;
//Décorateur
public abstract class Decorateur : ComposantGraphiqueVehicule
{
    protected readonly ComposantGraphiqueVehicule composant;

    public Decorateur(ComposantGraphiqueVehicule composant)
    {
        this.composant = composant;
    }
    public virtual void Affiche()
    {
        composant.Affiche();
    }
}
