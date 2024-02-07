using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Mediator.ExLivreDesignPatternCSharp;
//Element concret
public class Bouton : Controle
{
    public Bouton(string nom) : base(nom)
    {
    }
    public override void Saisie()
    {
        Console.WriteLine("Desirez-vous activer le bouton " + Nom + "?");
        string reponse = Console.ReadLine();
        if (reponse == "oui")
            this.Modifie();
    }
}

