using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeD.Exemple2._02_Apres
{
    public class DataAccessLayer
    {
        // On utilise le design pattern d'injection de dépendances
        private ILogger logger;
        public DataAccessLayer(ILogger logger)
        {
            this.logger = logger;
        }
        public void AddCustomer(string name)
        {
            logger.Log("Customer added : " + name);
        }
    }
}
