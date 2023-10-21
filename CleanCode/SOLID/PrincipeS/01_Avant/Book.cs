using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PrincipeS._01_Avant
{
    //La classe actuellement fait plusieurs choses.
    //- Elle transfert des données, c'est donc une DTO
    //- Elle sauvegarde aussi la classe dans un format Json
    // Il faut donc séparer les responsabilités
    public class Book
    {
        public string Title { get; set; } = "";
        public string Author { get; set; } = "";
        public int NbPages { get; set; }
        public string ISBN { get; set; } = "";
        public async Task SaveToFile()
        {
            await File.WriteAllTextAsync($"./book-{Title}.json", JsonSerializer.Serialize(this, new
                JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }));
        }
    }
}
