//Facade : Permet d'abstraire la complexité de récupération des données

using _10___Facade;

//Normalement la classe qui appelle la facade devrait aussi avoir une injection de dépendance,
//comme cela ca évite de faire les new comme cela
var service = new PersonneFacade(new PersonneService(), new AddressService(), new CommandeService());

var personne = service.GetInfos(1);
if(personne !=null)
    Console.WriteLine($"{personne.Nom} {personne.Prenom} : {personne.CodePostal} avec {personne.Commandes.Count()} commande(s)");


var personne2 = service.GetInfos(2);
Console.WriteLine($"Personne 2 null ? {personne2 is null}");

if (personne2 != null)
    Console.WriteLine($"{personne2.Nom} {personne2.Prenom} : {personne2.CodePostal} avec {personne2.Commandes.Count()} commande(s)");
