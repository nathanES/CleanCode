using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Facade
{
    //Ne pas prendre exemple sur le nom des ces classes qui ne sont pas terribles.
    //Ne pas faire des classes avec Service à la fin du nom. 
    public record Personne(int Id, string Nom, string Prenom, int AddressLatitude, int AddressLongitude);

    public class PersonneService
    {
        public Personne GetPersonne(int id)
        {
            return new Personne(id, "ESSLINGER", "Nathan", 9912, 31418);
        }
    }
    public record Address(string Rue, string CodePostal, string Pays);
    public class AddressService
    {
        public Address GetAddress(int longitude, int latitude)
        {
            return new Address("1 rue hello", "34000", "France");
        }
    }
    public record Commande(int Id, decimal Montant, DateTime Date);

    public class CommandeService
    {
        public IEnumerable<Commande> GetCommand(int personneId)
        {
            return new[] { 
                new Commande(1, 99.99m, DateTime.UtcNow),
                new Commande(2, 150.99m, DateTime.UtcNow),
                new Commande(3, 300.99m, DateTime.UtcNow)

            };
        }
    }
    public class PersonneAvecAddresseEtCommande
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Rue { get; set; }
        public string CodePostal { get; set; }
        public string Pays { get; set; }
        public IEnumerable<Commande> Commandes { get; set; }
    }

    public class PersonneFacade
    {
        private readonly PersonneService personneService;
        private readonly AddressService addressService;
        private readonly CommandeService commandeService;

        public PersonneFacade(PersonneService personneService,
            AddressService addressService, 
            CommandeService commandeService)
        {
            this.personneService = personneService;
            this.addressService = addressService;
            this.commandeService = commandeService;
        }
        public PersonneAvecAddresseEtCommande GetInfos(int id)
        {
            var personne = personneService.GetPersonne(id);
            if(personne is not null)
            {
                var address = addressService.GetAddress(personne.AddressLongitude, personne.AddressLatitude);
                var commandes = commandeService.GetCommand(id);
                return new PersonneAvecAddresseEtCommande
                {
                    Id = id,
                    Nom = personne.Nom,
                    Prenom = personne.Prenom,
                    CodePostal= address?.CodePostal ?? "99999",
                    Pays = address?.Pays ?? "France",
                    Rue = address?.Rue ?? "Rue inconnue",
                    Commandes= commandes
                };
            }
            return null;

        }
    }
}
