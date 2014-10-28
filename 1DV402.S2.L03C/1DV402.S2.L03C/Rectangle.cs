using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03C
{
    /// <summary>
    /// Class rectangle inherits from Shape2D
    /// </summary>
    class Rectangle : Shape2D
    {
        /// <summary>
        /// Calculates Area
        /// </summary>
        public override double Area
        {
            get
            {
                
               return Length * Width;
            }
        }
        /// <summary>
        /// Calculates Perimeter
        /// </summary>
        public override double Perimeter
        {
            get
            {
                return 2 * Length + 2 * Width;
            }
        }
        /// <summary>
        /// Constructor, calls constructor i Shape2D class
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Rectangle(double length, double width)
            : base(ShapeType.Rectangle, length, width)
        {
            //Empty...
        }

    }
}
