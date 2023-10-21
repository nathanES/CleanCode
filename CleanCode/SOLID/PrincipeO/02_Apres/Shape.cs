using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeO._02_Apres
{
    public abstract class Shape
    {
        //on met en propriété plutôt qu'en fonction
        //car ceux qui vont hériter de cette classe sont des DTO
        public abstract int Surface { get; }
    }
}
