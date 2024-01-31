using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Facade.ExLivreDesignPatternCSharp;
public class ComposantGestionDocument : IGestionDocument
{
    public string Document(int index)
    {
        return "Document numéro " + index;
    }
}
