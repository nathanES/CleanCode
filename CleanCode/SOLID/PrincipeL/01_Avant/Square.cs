using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeL._01_Avant
{
    public class Square : Shape
    {
        public int SideSize { get; set; }
        public override int Surface => 
            SideSize * SideSize;
    }
}
