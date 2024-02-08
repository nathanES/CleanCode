using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___Memento.ExLivreDesignPatternCSharp;
public class MementoImpl : IMemento
{
    protected IList<OptionVehicule> options = new List<OptionVehicule>();
    public IList<OptionVehicule> Etat
    {
        get
        {
            return options;
        }
        set
        {
            this.options.Clear();
            foreach (OptionVehicule option in value)
            {
                this.options.Add(option);
            }
        }
    }
}
