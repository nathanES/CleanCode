using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Iterator.ExLivreDesignPatternCSharp;
//Element
public abstract class Element
{
    protected string Description;
    public Element(string description)
    {
        this.Description = description;
    }
    public bool MotCleValide(string motCle)
    {
        return Description.IndexOf(motCle) != -1;
    }
}
