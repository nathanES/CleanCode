using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PrincipeS._02_Apres
{
    // Un repository est un pattern qui permet d'abstraire l'accès aux
    // données nous permettant de lire et écrire des données
    // sans pour autant se préoccuper de où ils sont stockés
    public class BookRepository
    {
        public async Task SaveToFile(Book book)
        {
            await File.WriteAllTextAsync($"./book-{book.Title}.json", JsonSerializer.Serialize(book, new
                JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }));
        }
    }
}
