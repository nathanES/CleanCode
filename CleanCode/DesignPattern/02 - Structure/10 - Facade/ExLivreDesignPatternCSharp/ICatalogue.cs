using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Facade.ExLivreDesignPatternCSharp;
//Composant/classe du système
public interface ICatalogue
{
    IList<string> RetrouveVehicules(int prixMin, int prixMax);
}
