﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeD._02_Apres
{
    public interface IWriteRepository
    {
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
        Task Save(); //Pattern unit of work
    }
}
