using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeD.Exemple1._02_Apres
{
    public class BookRepository : IRepository
    {
        private List<Book> books = new();
        public void Add(Book book) => books.Add(book);
        public void Delete(Book book) => books.Remove(book);
        public IEnumerable<Book> GetAll() => books;
        public Book? GetById(int id) => books.FirstOrDefault(b => b.Id == id);
        public Task Save() => Task.CompletedTask;
        public void Update(Book book)
        {
            books.RemoveAll(b => b.Id == book.Id);
            books.Add(book);
        }
    }
}
