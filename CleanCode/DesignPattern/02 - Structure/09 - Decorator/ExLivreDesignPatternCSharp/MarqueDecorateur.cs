using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Decorator.ExLivreDesignPatternCSharp;
//Decorateur concret
public class MarqueDecorateur : Decorateur
{

    public MarqueDecorateur(ComposantGraphiqueVehicule composant) : base(composant)
    {
    }

    protected void AfficheLogo()
    {
        Console.WriteLine("Logo de la marque");
    }

    public override void Affiche()
    {
        base.Affiche();
        this.AfficheLogo();
    }
}
