using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeL._01_Avant
{
    public class Line : Shape
    {
        //Ne respecte pas le principe L car il génère pas le même comportement qu'une autre Shape
        public override int Surface => throw new NotImplementedException();
    }
}
