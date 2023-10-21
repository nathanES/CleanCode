using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipeO._01_Avant
{
    public class SurfaceCalculator
    {
        //Le problème c'est que si on ajoute une nouvelle forme,
        //on doit modifier à chaque fois cette classe

        //Cette classe respecte le principe S mais le principe O
        //pousse le curseur encore plus loin
        public int ComputeAllSizes(IEnumerable<object> shapes)
        {
            int result = 0;
            foreach (var shape in shapes)
            {
                result += ComputeSize(shape);
            }
            return result;
        }
        private int ComputeSize(object shape)
            => shape switch
            {
                Square s => s.SideSize * s.SideSize,
                Rectangle r => r.Width * r.Height,
               _ => throw new InvalidOperationException(nameof(shape))
            };
        //{
        //    if (shape is Square s)
        //        return s.SideSize * s.SideSize;
        //    else if (shape is Rectangle r)
        //        return r.Width * r.Height;
        //    else
        //        throw new InvalidOperationException(nameof(shape));

        //}
    }
}
