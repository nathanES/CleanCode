using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeD.Exemple1._01_Avant
{
    public interface IReadRepository
    {
        Book? GetById(int id);
        IEnumerable<Book> GetAll();
    }
}
