//Decorator : Permet d'ajouter un comportement ou des données à une classe
using _09___Decorator;

var azure = new AzureNewsletterSender();
var database = new NewsletterDatabaseDecorator(azure);
var stats = new NewsletterStatisticsDecorator(database);

await stats.SendNewsletter("ma newsletter1");
await stats.SendNewsletter("ma newsletter2");

Console.WriteLine("Nb newsletters envoyées : " + NewsletterStatisticsDecorator.NbNewsletterSent);