using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Facade.ExLivreDesignPatternCSharp;
public class WebServiceAutoImpl : IWebServiceAuto
{
protected ICatalogue catalogue = new ComposantCatalogue();
protected IGestionDocument gestionDocument = new ComposantGestionDocument();
    public IList<string> ChercheVehicules(int prixMoyen, int ecartMax)
    {
        return catalogue.RetrouveVehicules(prixMoyen - ecartMax, prixMoyen + ecartMax);
    }

    public string Document(int index)
    {
        return gestionDocument.Document(index);
    }
}
