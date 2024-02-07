using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Mediator.ExLivreDesignPatternCSharp;
//Element concret
public class ZoneSaisie : Controle
{
    public ZoneSaisie(string nom) : base(nom)
    {
    }
    public override void Saisie()
    {
        Console.WriteLine("Saisie de : " + this.Nom);
        this.Valeur = Console.ReadLine();
        this.Modifie();
    }
}
