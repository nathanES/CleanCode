using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeD.Exemple2._02_Apres
{
    public class LoggerFactory
    {
        public ILogger GetLogger(bool isDbAvailable)
        {
#if DEBUG
            return new ConsoleLogger();
#endif
            if (isDbAvailable)
                return new DbLogger();
            else
                return new FileLogger();
        }
    }
}
