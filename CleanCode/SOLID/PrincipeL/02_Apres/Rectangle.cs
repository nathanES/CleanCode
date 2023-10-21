using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeL._02_Apres
{
    public class Rectangle : ShapeWithSurface
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public override int Surface => Height * Width;
    }
}
