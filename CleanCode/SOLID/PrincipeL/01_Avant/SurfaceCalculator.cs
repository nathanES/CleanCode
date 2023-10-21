using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeL._01_Avant
{
    public class SurfaceCalculator
    {
        public int ComputeSurface(Shape shape)
        {
            return shape.Surface;
        }
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
