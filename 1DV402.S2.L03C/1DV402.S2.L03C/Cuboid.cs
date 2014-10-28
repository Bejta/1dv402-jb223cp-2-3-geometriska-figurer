using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03C
{
    /// <summary>
    /// Class for all cuboids, inherite from class Shape3D
    /// </summary>
    class Cuboid : Shape3D
    {
        /// <summary>
        /// Calculates Mantel Area of cuboid
        /// </summary>
        public override double MantelArea
        {
            get
            {
                return _baseShape.Perimeter * Height;
            }
        }
        /// <summary>
        /// Calculates Surface Area of cuboid
        /// </summary>
        public override double TotalSurfaceArea
        {
            get
            {
                return MantelArea + 2 * _baseShape.Area;
            }
        }
        /// <summary>
        /// Calculate Volume of cuboid
        /// </summary>
        public override double Volume
        {
            get
            {
                return _baseShape.Area * Height;
            }
        }
        /// <summary>
        /// Constructor with 3 arguments, calls constructor in base class
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Cuboid(double length, double width, double height)  
            : base(ShapeType.Cuboid, new Rectangle(length, width), height )
        { 
            //Empty...
        } 
    }
}
