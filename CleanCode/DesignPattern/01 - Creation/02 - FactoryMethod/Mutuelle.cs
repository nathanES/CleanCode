using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___FactoryMethod
{
    public abstract class Mutuelle
    {
        public abstract decimal GetPourcentageRemboursementMedecinTraitant();
    }
    public class PasDeMutuelle : Mutuelle
    {
        public override decimal GetPourcentageRemboursementMedecinTraitant()
            => 0m;
    }
    public class LesOisillonsMutuelle : Mutuelle
    {
        public override decimal GetPourcentageRemboursementMedecinTraitant() 
            => 100m;
    }
    public class LeopardMutuelle : Mutuelle
    {
        public override decimal GetPourcentageRemboursementMedecinTraitant() 
            => 150m;
    }
}
