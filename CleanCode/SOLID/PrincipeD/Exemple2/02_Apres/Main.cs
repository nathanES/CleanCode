using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeD.Exemple2._02_Apres
{
    public class Main
    {
        public Main()
        {
            //Exemple sans factory
            ILogger logger = new FileLogger();
            DataAccessLayer dataAccess = new DataAccessLayer(logger);
            dataAccess.AddCustomer("Nat");

            //ILogger logger2 = new DbLogger();
            //DataAccessLayer dataAccess2 = new DataAccessLayer(logger2);
            //dataAccess2.AddCustomer("Nat");

            //Exemple avec factory (Encore mieux avec le design pattern factory)
            bool isDbAvailable = true;
            LoggerFactory loggerFactory = new LoggerFactory();
            ILogger logger3 = loggerFactory.GetLogger(isDbAvailable);
            DataAccessLayer dataAccess3 = new DataAccessLayer(logger3);
            dataAccess3.AddCustomer("Nat");
        }
    
    }
}

