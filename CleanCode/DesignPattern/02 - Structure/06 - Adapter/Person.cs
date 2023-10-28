using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Adapter
{
    //Représentation sous forme de classe qu'on aurait d'une requete API par exemple
    public class PersonExternal
    {
        public int ID { get; set; }
        public string FullName { get; set; }
    }

    public class ExternalPersonAPIService
    {//cette classe devrait être abstraite...
        public PersonExternal GetPerson()
            => new PersonExternal() { ID = 1, FullName = "ESSLINGER Nathan" };

    }



   //Dans notre BDD
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
