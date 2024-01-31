using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Decorator.ExLivreDesignPatternCSharp;
//Decorateur concret
public class ModeleDecorateur : Decorateur
{
    public ModeleDecorateur(ComposantGraphiqueVehicule composant) : base(composant)
    {
    }
    protected void AfficheInfosTechniques()
    {
        Console.WriteLine("Informations techniques du modèle");
    }

    public override void Affiche()
    {
        base.Affiche();
        this.AfficheInfosTechniques();
    }
}
