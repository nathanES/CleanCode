using PrincipeI._01_Avant;

namespace PrincipeI
{
    internal class Program
    {
        //Principe I : Interface Segregation Principle
        //Au lieu d'avoir une interface qui fait tout, il vaut mieux avoir plusieurs
        //  petites interfaces qui ont des rôles spécifiques
        static void Main(string[] args)
        {
            //Cela fonctionne, mais le problème c'est quelle fait trop de chose et qu'on prend
            //  toutes les méthodes qu'elle fait alors qu'on en a besoin que d'une petite partie
            #region Avant
            DisplayAllBooks(new BookRepository());
            void DisplayAllBooks(IRepository repository)
            {
                var books = repository.GetAll();
                foreach (var book in books)
                {
                    Console.WriteLine(book.Title);
                    repository.Delete(book);

                }
            }
            #endregion
            //Il faut écrire une interface par fonction logique business
            //Cela permet de pouvoir expliquer exactement comment le code est censée fonctionner

            #region Apres
            DisplayAllBooksApres(new _02_Apres.BookRepository());
            void DisplayAllBooksApres(_02_Apres.IReadRepository repository)
            {
                var books = repository.GetAll();
                foreach (var book in books)
                {
                    Console.WriteLine(book.Title);
                    //repository.Delete(book);//Error
                }
            }
            #endregion
        }
    }
}