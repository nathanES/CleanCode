using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _09___Decorator
{
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
    //Permet de rajouter de l'information sans toucher à la classe Personne
    public class PersonneWrapper
    {
        private readonly Personne personne;
        public string Nom { get => personne.Nom; set => personne.Nom = value;}
        public DateTime DateInsctiption { get; set; }
        public string NomComplet => $"{personne.Prenom} {personne.Nom}";

        public PersonneWrapper(Personne personne)
        {
            personne = personne;
        }
    }
    public interface INewsletterSender
    {
        Task<bool> SendNewsletter(string content);
    }
    public class AzureNewsletterSender : INewsletterSender 
    {
        public Task<bool> SendNewsletter(string content) 
        {
            Console.WriteLine("Newsletter envoyée avec succès depuis Azure !");
            return Task.FromResult(true);
        }
    }
    public abstract class NewsletterSenderDecorator : INewsletterSender
    {
        private readonly INewsletterSender sender;
        public NewsletterSenderDecorator(INewsletterSender sender)
        {
            this.sender = sender;
        }

        public virtual Task<bool> SendNewsletter(string content)
        {
            return sender.SendNewsletter(content);
        }
    }
    public class NewsletterDatabaseDecorator : NewsletterSenderDecorator
    {
        public NewsletterDatabaseDecorator(INewsletterSender sender) 
            : base(sender)
        {
        }
        public override Task<bool> SendNewsletter(string content)
        {
            Console.WriteLine("Sauvegarde en BDD du contenu :" + content);
            return base.SendNewsletter(content);
        }
    }
    public class NewsletterStatisticsDecorator : NewsletterSenderDecorator
    {
        public static int NbNewsletterSent = 0;
        public NewsletterStatisticsDecorator(INewsletterSender sender)
            : base(sender)
        {
        }
        public override Task<bool> SendNewsletter(string content)
        {
            NbNewsletterSent++;
            return base.SendNewsletter(content);
        }
    }

}
