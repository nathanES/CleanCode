﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeO._02_Apres
{
    public class SurfaceCalculator
    {
        public int ComputeAllSize(IEnumerable<Shape> shapes)
        {
            int result = 0;
            foreach (Shape shape in shapes)
            {
                result += shape.Surface;
            }
            return result;
        }
    }
}
