using System.Runtime.InteropServices;

namespace PrincipeS
{
    internal class Program
    {
        //Principe S : Single Responsability Principe
        //Une classe ne doit avoir qu'une et unique raison d'être modifié
        //La classe peut avoir plusieurs méthodes.
        static void Main(string[] args)
        {
            //On avait d'abord Book qui faisait le DTO et la sauvegarde,
            //cela ne respectait pas le pricipe P car si on voulait modifier la sauvegarde
            //ou le DTO, cela impactait la même classe

            //Pour respecter le principe P on a créé une classe BookRepository
            //qui s'occupe de la sauvegarde
            //Et on a fait en sorte que Book ne fait que du DTO
            //Comme cela si on veut modifier le DTO, on ne modifie que la classe Book
            //Et si on veut modifier la sauvegarde ou autre on modifie BookRepository
        }
    }
}