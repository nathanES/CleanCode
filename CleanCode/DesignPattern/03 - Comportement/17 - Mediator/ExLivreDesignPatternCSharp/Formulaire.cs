using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Mediator.ExLivreDesignPatternCSharp;
//Mediateur concret
public class Formulaire
{
    protected IList<Controle> Controles = new List<Controle>();
    protected IList<Controle> ControlesCoenmprunteur = new List<Controle>();
    public PopupMenu MenuCoemprunteur { protected get; set; }
    public Bouton BoutonOK { protected get; set; }
    protected bool enCours = true;

    public void AjouteControle(Controle controle)
    {
        Controles.Add(controle);
        controle.Directeur = this;
    }
    public void AjouteControleCoemprunteur(Controle controle)
    {
        ControlesCoenmprunteur.Add(controle);
        controle.Directeur = this;
    }
    public void ControleModifie(Controle controle)
    {
        if (controle == MenuCoemprunteur)
        {
            if (controle.Valeur == "avec coemprunteur")
            {
                foreach (Controle elementCoemprunteur in ControlesCoenmprunteur)
                {
                    elementCoemprunteur.Saisie();
                }
            }
            if (controle == BoutonOK)
            {
                enCours = false;
            }
        }
    }
    public void Saisie()
    {
        while (true)
        {
            foreach (Controle controle in Controles)
            {
                controle.Saisie();
                if (!enCours)
                    return;
            }

        }
    }
}
