using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeD.Exemple2._01_Avant
{
    public class DataAccessLayer  //DataAccessLayer => Higher level class
    {
        public void AddCustomer(string name)
        {
            FileLogger logger = new FileLogger(); //FileLogger => Lower level class
            logger.Log("Customer added : " + name);
        }
    }
}
