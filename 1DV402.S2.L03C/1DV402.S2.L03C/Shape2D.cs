using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03C
{
    /// <summary>
    /// Class for 2D Shapes inherits from Shape class and IComparable interface
    /// </summary>
    public abstract class Shape2D : Shape, IComparable
    {
        /// <summary>
        /// Encapsulated fields
        /// </summary>
        private double _length;
        private double _width;
        /// <summary>
        /// Abstract property Area
        /// </summary>
        public abstract double Area
        {
            get;
        }
        /// <summary>
        /// Property Length
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException();

                _length = value;
            }
        }
        /// <summary>
        /// Property perimeter
        /// </summary>
        public abstract double Perimeter
        {
            get;
        }
        /// <summary>
        /// Property width
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException();

                _width = value;
            }
        }
        /// <summary>
        /// Member of Interface IComparable, compares area of two shapes
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Shape2D otherShape2D = obj as Shape2D;
            if (otherShape2D != null)
                return this.Area.CompareTo(otherShape2D.Area);
            else
                throw new ArgumentException("Går inte att jämföra objekter, därför att ett objekt är inte av typen Shape!");
        }
        /// <summary>
        /// Protected constuctor that calls constructor in abstract class Shape
        /// </summary>
        /// <param name="shapeType"></param>
        /// <param name="length"></param>
        /// <param name="width"></param>
        protected Shape2D(ShapeType shapeType, double length, double width)
            : base(shapeType)
        {
            Length = length;
            Width = width;
        }
        /// <summary>
        /// Overrides ToString in class Object....
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string values = string.Format("{0,-12}{1,8:f1}{2,6:f1}{3,8:f1}{4,9:f1}", ShapeType, Length, Width, Perimeter, Area);
            return values;
        }
        /// <summary>
        /// Override ToString method from object class. Example from MSDN site, reference in laboratory pdf....
        /// </summary>
        /// <param name="format"></param>
        /// <returns></returns>
        public override string ToString(string format)
        {
            {
                // Handle null or empty string. 
                if (String.IsNullOrEmpty(format)) format = "G";
                // Remove spaces and convert to uppercase.
                format = format.Trim().ToUpperInvariant();

                switch (format)
                {
                    case "G":
                        return String.Format("Längd     :{0,9:f1}\nBredd     :{1,9:f1}\nOmkrets   :{2,9:f1}\nArea      :{3,9:f1}\n", Length, Width, Perimeter, Area);
                    case "R":
                        return this.ToString();
                    default:
                        throw new FormatException(String.Format("'{0}' är inte ett gilltigt värde", format));
                }

            }
        }
    }
}
