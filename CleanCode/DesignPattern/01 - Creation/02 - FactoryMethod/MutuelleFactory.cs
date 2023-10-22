using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___FactoryMethod
{
    public class Patient
    {
        public string? NumeroMutuelle { get; set; }
    }
    public class MutuelleFactory
    {
        public Mutuelle GetMutuelle(Patient patient) {
            if (string.IsNullOrEmpty(patient.NumeroMutuelle))
                return new PasDeMutuelle();
            else if (patient.NumeroMutuelle.StartsWith("003"))
                return new LesOisillonsMutuelle();
            else
                return new LeopardMutuelle();        
        }
    }

    #region pour les objets plus complexe
    public abstract class MutuelleFactory2
    {
        public abstract Mutuelle GetMutuelle(Patient patient);
    }

    public class LesOisillonsMutuelleFactory : MutuelleFactory2
    {
        public override Mutuelle GetMutuelle(Patient patient)
        {
            return new LesOisillonsMutuelle();
        }
    }

    #endregion
}
