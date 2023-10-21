using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeI._01_Avant
{
    public interface IRepository
    {
        Book? GetById(int id);
        IEnumerable<Book> GetAll();
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
        Task Save();
    }
}
