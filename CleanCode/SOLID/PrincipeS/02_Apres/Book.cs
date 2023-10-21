using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeS._02_Apres
{
    //Transformation :
    //1. On crée un BookRepository qui va s'occuper de la méthode
    //qui enregistrait les données au format JSON
    //2. On enlève la méthode qui enregistrait et on l'a met dans le BookRepository

    // Maintenant Book va faire que du DTO
    // BookRepository va faire tout ce qui est sauvegarde...
    public class Book
    {
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public int NbPages { get; set; }
        public string ISBN { get; set; } = "";

    }
}
