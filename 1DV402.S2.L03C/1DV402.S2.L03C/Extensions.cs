using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03C
{
    public static class Extensions
    {
        /// <summary>
        /// Converts enum datatype to string
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        public static string AsText(this ShapeType shapeType)
        {
            switch (shapeType)
            {
                case(ShapeType.Rectangle):
                    return "Rectangle";
                case(ShapeType.Circle):
                    return "Circle";
                case (ShapeType.Ellipse):
                    return "Ellipse";
                case (ShapeType.Cylinder):
                    return "Cylinder";
                case (ShapeType.Cuboid):
                    return "Cuboid";
                default:
                    return "Sphere";
            }
        }
        /// <summary>
        /// Method to align string to center. Example from stackoverflow found in Mats program about Recipes.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static string CenterAlignString (this string s, string other)
        {
            return s.PadLeft(((other.Length - s.Length) / 2) + s.Length).PadRight(other.Length);
        }
    }
}
