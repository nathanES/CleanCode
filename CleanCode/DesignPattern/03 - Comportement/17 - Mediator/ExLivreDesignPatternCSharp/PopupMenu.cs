using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Mediator.ExLivreDesignPatternCSharp;
//Element concret
public class PopupMenu : Controle
{
protected List<string> options = new List<string>();
    public PopupMenu(string nom) : base(nom)
    {
    }
    public override void Saisie()
    {
        Console.WriteLine("Saisie de : " + Nom);
        Console.WriteLine("Valeur actuelle :" + Valeur);
        for(int i = 0; i < options.Count; i++)
        {
            Console.WriteLine("- " + i + " )" + options[i]);
        }
        int choix = int.Parse(Console.ReadLine());
        if ((choix >= 0) && (choix < options.Count))
        {
            bool change = (Valeur != options[choix]);
            if(change)
            {
                Valeur = options[choix];
                this.Modifie();
            }
        }
    }
    public void AjouteOption(string option)
    {
        options.Add(option);
    }
}
