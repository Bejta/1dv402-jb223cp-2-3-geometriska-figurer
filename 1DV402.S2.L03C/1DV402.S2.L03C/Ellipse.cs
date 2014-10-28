using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03C
{
    /// <summary>
    /// Class Ellipse
    /// </summary>
    class Ellipse : Shape2D
    {
        /// <summary>
        /// Calculates Area of Ellipse or circle
        /// </summary>
        public override double Area
        {
            get
            {
                return Math.PI * (Length / 2) * (Width / 2);
            }
        }
        /// <summary>
        /// Calculates Perimeter of Ellipse or Circle
        /// </summary>
        public override double Perimeter
        {
            get 
            {
                return Math.PI * Math.Sqrt(2 * (Length / 2) * (Length / 2) + 2 * (Width / 2) * (Width / 2));
            }
        }
        /// <summary>
        /// Constructor with one argument, in the case of circle
        /// </summary>
        /// <param name="diameter"></param>
        public Ellipse(double diameter):base(ShapeType.Circle,diameter,diameter)
        {
            //Empty...
        }
        /// <summary>
        /// Constructor with 2 parameters in the case of ellipse
        /// </summary>
        /// <param name="hdiameter"></param>
        /// <param name="vdiameter"></param>
        public Ellipse(double hdiameter,double vdiameter):base(ShapeType.Ellipse,hdiameter,vdiameter)
        {
            //Empty...
        }
    }
   
}
