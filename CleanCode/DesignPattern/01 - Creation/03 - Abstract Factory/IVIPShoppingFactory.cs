using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Abstract_Factory
{
    public interface IPrioriteCommande
    {
        int Priorite { get;}
    }
    public interface IPourcentReduction
    {
        decimal Pourcentage { get; }
    }
    public class StandardPrioriteCommand : IPrioriteCommande
    {
        public int Priorite => 0;
    }
    public class VIPPrioriteCommand : IPrioriteCommande
    {
        public int Priorite => 1;
    }
    public class StandardPourcentReduction : IPourcentReduction
    {
        public decimal Pourcentage => 0m;
    }
    public class VIPPourcentReduction : IPourcentReduction
    {
        public decimal Pourcentage => 15m;
    }

    internal interface IVIPShoppingFactory
    {
        IPourcentReduction GetReduction();
        IPrioriteCommande GetPriorite();
    }
    public class VIPShoppingFactory : IVIPShoppingFactory
    {
        public IPrioriteCommande GetPriorite() => new VIPPrioriteCommand();
        public IPourcentReduction GetReduction() => new VIPPourcentReduction();
    }
    public class StandardShoppingFactory : IVIPShoppingFactory
    {
        public IPrioriteCommande GetPriorite() => new StandardPrioriteCommand();
        public IPourcentReduction GetReduction() => new StandardPourcentReduction();
    }
}
