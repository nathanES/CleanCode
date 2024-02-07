using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Iterator.ExLivreDesignPatternCSharp;
//Collection
public abstract class Catalogue<TElement, TIterateur>   where TElement : Element 
                                                        where TIterateur : Iterateur<TElement>, new()
{
    protected IList<TElement> Contenu = new List<TElement>();
    public TIterateur Recherche(string motCleRecherche)
    {
        TIterateur resultat = new TIterateur();
        resultat.MotCleRecherche = motCleRecherche;
        resultat.Contenu = Contenu;
        return resultat;
    }
}
