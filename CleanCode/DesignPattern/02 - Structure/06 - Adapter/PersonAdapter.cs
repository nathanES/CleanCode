using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Adapter
{
    //C# préfère la composition plutot que l'heritage
    //Object Adapter
    public interface IPersonAdapter //Il doit y avoir un adapteur par type, un airfranceAdapter, un KayakAdapter,...
    {
        Person GetPerson(); //devrait être asynchrone comme c'est pour une api et avec les
                            //transferts réseau il peut y avoir des problèmes
    }
    public class PersonAdapter : IPersonAdapter
    {
        private readonly ExternalPersonAPIService service;

        public PersonAdapter(ExternalPersonAPIService service)
        {
            this.service = service;
        }
        public Person GetPerson()
        {
            var externalPerson = service.GetPerson();
            var names = externalPerson.FullName.Split(' ');
            return new Person
            {
                ID = externalPerson.ID,
                LastName = names[0],
                Name = names[1]
            };
        }
    }
    
    //Classe Adapter, moins bien
    public class ExternalPersonAdapter : ExternalPersonAPIService, IPersonAdapter
    {
        public new Person GetPerson()
        {
            var externalPerson = base.GetPerson();
            var names = externalPerson.FullName.Split(' ');
            return new Person
            {
                ID = externalPerson.ID,
                LastName = names[0],
                Name = names[1]
            };
        }
    }
}
