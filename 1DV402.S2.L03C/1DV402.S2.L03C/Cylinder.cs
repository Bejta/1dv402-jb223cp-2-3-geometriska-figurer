using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03C
{
    /// <summary>
    /// Class for all Cylinders, inherite from class Shape3D
    /// </summary>
    class Cylinder:Shape3D
    {
        /// <summary>
        /// Calculates Mantel area of cylinder
        /// </summary>
        public override double MantelArea 
         { 
            get 
            { 
                 return _baseShape.Perimeter * Height; 
             } 
         } 
        /// <summary>
        /// Calculated Surface area of Cylinder
        /// </summary>
        public override double TotalSurfaceArea 
        { 
            get 
             { 
                return MantelArea + 2 * _baseShape.Area; 
            } 
         } 
        /// <summary>
        /// Calculate Volume of Cylinder
        /// </summary>
        public override double Volume 
        { 
            get 
            { 
                 return _baseShape.Area * Height; 
            } 
         } 
        /// <summary>
        /// Constructor with 3 arguments
        /// </summary>
        /// <param name="hradius"></param>
        /// <param name="vradius"></param>
        /// <param name="height"></param>
        public Cylinder(double hradius, double vradius, double height)  
            : base(ShapeType.Cylinder, new Ellipse(hradius, vradius), height)
        {
            //Empty...
        } 
    }
}
