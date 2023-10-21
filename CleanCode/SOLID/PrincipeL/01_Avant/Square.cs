using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeL._02_Apres
{
    public class Square : Shape
    {
        public int SideSize { get; set; }
        public override int Surface => SideSize * SideSize;
    }
}
