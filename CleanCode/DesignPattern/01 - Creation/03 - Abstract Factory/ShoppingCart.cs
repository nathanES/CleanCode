using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Abstract_Factory
{
    public class Customer
    {
        public int[] Orders { get; set; } = Array.Empty<int>();
    }
    public class ShoppingCart
    {
        private readonly IVIPShoppingFactory _factory;
        public ShoppingCart(IVIPShoppingFactory factory)
        {

            _factory = factory;

        }
        public void PasserCommande()
        {
            var priorite = _factory.GetPriorite().Priorite;
            var pourcent = _factory.GetReduction().Pourcentage;
            Console.WriteLine("Priorite = " + priorite);
            Console.WriteLine("Pourcent = " + pourcent);
        }
    }
}
