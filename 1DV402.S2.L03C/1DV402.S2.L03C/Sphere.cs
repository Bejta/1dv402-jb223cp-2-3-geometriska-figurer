using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03C
{
    /// <summary>
    /// class for sphere, inherits from Shape3D class
    /// </summary>
    class Sphere:Shape3D
    {
        /// <summary>
        /// Calculates Mantel area
        /// </summary>
        public override double MantelArea 
         { 
             get 
            { 
                return _baseShape.Area * 4; 
            } 
         } 
        /// <summary>
        /// Calculates surface area
        /// </summary>
        public override double TotalSurfaceArea 
        { 
            get 
            { 
                return _baseShape.Area * 4; 
           } 
        } 
        /// <summary>
        /// calculates volume
        /// </summary>
        public override double Volume 
         { 
            get 
             { 
                 return 4 / 3 * _baseShape.Area * Height / 2; 
            } 
         } 
        /// <summary>
        /// Constructor with radius as parameter, calls constructor in Shape2D class
        /// </summary>
        /// <param name="radius"></param>
        public Sphere(double radius)  
             : base(ShapeType.Sphere, new Ellipse(radius * 2), radius * 2) 
        {
            //Empty...
        } 
     } 
}
