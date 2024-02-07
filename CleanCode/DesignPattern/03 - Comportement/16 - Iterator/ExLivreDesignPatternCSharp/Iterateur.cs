using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Iterator.ExLivreDesignPatternCSharp;
//Iterateur
public abstract class Iterateur<TElement> where TElement : Element
{

    public string MotCleRecherche { protected get; set; }
    protected int Index;
    public IList<TElement> Contenu { protected get; set; }

    public void Debut()
    {
        Index = 0;
        int taille = Contenu.Count;
        while (Index < taille && !Contenu[Index].MotCleValide(MotCleRecherche))
        {
            Index++;
        }
    }
    public void Suivant()
    {
        int taille = Contenu.Count;
        Index++;
        while (Index < taille && !Contenu[Index].MotCleValide(MotCleRecherche))
        {
            Index++;
        }
    }

    public TElement Item()
    {
        if (Index < Contenu.Count)
        {
            return Contenu[Index];
        }
        else
        {
            return null;
        }
    }
}
