using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeL._02_Apres
{
    public class SurfaceCalculator
    {
        public int ComputeSurface(ShapeWithSurface shape)
        {
            return shape.Surface;
        }
        public int ComputeAllSize(IEnumerable<ShapeWithSurface> shapes)
        {
            int result = 0;
            foreach (ShapeWithSurface shape in shapes)
            {
                result += shape.Surface;
            }
            return result;
        }
    }
}
