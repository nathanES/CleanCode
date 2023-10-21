﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeI._02_Apres
{
    public interface IReadRepository
    {
        Book? GetById(int id);
        IEnumerable<Book> GetAll();
    }
}
