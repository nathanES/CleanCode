using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Mediator.ExLivreDesignPatternCSharp;
//Element
public class Controle
{
    public string Valeur { get; protected set; }
    public Formulaire Directeur { protected get; set; }
    public string Nom { get; protected set; }
    public Controle(string nom)
    {
    this.Valeur = "";
        this.Nom = nom;
    }
    public abstract void Saisie();
    public void Modifie()
    {
        this.Directeur.ControleModifie(this);
    }
}
