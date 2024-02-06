using _01_Avant = PrincipeD.Exemple1._01_Avant;
using _02_Apres = PrincipeD.Exemple1._02_Apres;



namespace PrincipeD
{
    internal class Program
    {
        //Principe D : Depedency Inversion Principe
        //Il est préférable que ton code métier dépande d'abstraction
        //  et non d'implémentation 

        //Si dans le futur il y a des changements de BDD ou autre, si elles héritent
        //  de la même interface, il y a seulement à un seul endroit dans le code qu'il
        //  faudra modifier (au moment de l'injection de dépendances par exemple)
        static void Main(string[] args)
        {
#region Avant
            BookManager(new _01_Avant.BookRepository());
            void BookManager(_01_Avant.BookRepository repo)
            {
                //Menu pour gérer
                //1. récupérer les livres
                repo.GetAll();
            }
            #endregion
            //Si on nous demandes de faire plutôt une sauvegarde dans un fichier
            //  à la place d'une BDD
            #region Apres
            BookManager2(new _02_Apres.BookRepository());
            BookManager2(new _02_Apres.FileBookRepository());
            //Si on couple avec le moteur d'injection de dépendance,
            //  il y aura seulement à un seul endroit ou on dit qu'un
            //  IRepository est un BookRepository 


            //Utilisation de l'interface commune.
            //  /!\ Attention il faut qu'en même respecter le pricipe de Liskov
            void BookManager2(_02_Apres.IRepository repo)  
            {
                //Menu pour gérer
                //1. récupérer les livres
                repo.GetAll();
            }
            #endregion
        }
    }
}