using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Facade.ExLivreDesignPatternCSharp;
//Facade
//Les clients de la facade ne doivent pas avoir accès aux objets du système
public interface IWebServiceAuto
{
string Document(int index);
    IList<string> ChercheVehicules(int prixMoyen, int ecartMax);
}
