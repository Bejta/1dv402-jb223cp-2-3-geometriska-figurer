using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03C
{
    public abstract class Shape3D : Shape, IComparable
    {
        /// <summary>
        /// Encapsulated fields
        /// </summary>
        protected Shape2D _baseShape;
        private double _height;
        /// <summary>
        /// Properties which are abstract (has to be implemented in inherited classes)
        /// </summary>
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("FEL!");
                }
                _height = value;
            }
        }
        public abstract double MantelArea
        {
            get;
        }
        public abstract double TotalSurfaceArea
        {
            get;
        }
        public abstract double Volume
        {
            get;
        }
        /// <summary>
        /// CompareTo metod implementation from Interface IComparable (example from MSDN site)
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Shape3D otherShape3D = obj as Shape3D;
            if (otherShape3D != null)
                return this.Volume.CompareTo(otherShape3D.Volume);
            else
                throw new ArgumentException("Går inte att jämföra objekter, därför att ett objekt är inte av typen Shape!");
        }
        /// <summary>
        /// Constructor that calls constructor from base class
        /// </summary>
        /// <param name="shapeType"></param>
        /// <param name="baseShape"></param>
        /// <param name="height"></param>
        protected Shape3D(ShapeType shapeType, Shape2D baseShape, double height)  
            : base(shapeType) 
        { 
            _baseShape = baseShape; 
            Height = height; 
        }
        /// <summary>
        /// Overrides method ToString (takes no arguments) from base class object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string values = string.Format("{0,-11}{1,5:f1}{2,6:f1}{3,6:f1}{4,13:f1}{5,13:f1}{6,13:f1}", ShapeType, _baseShape.Length, _baseShape.Width,Height, MantelArea, TotalSurfaceArea, Volume);
            return values;
        }

        /// <summary>
        /// Overrides method ToString from base class object
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
                        return String.Format("Längd           :{0,9:f1}\nBredd           :{1,9:f1}\nHöjd            :{2,9:f1}\nMantelarea      :{3,9:f1}\nBegränsningarea :{4,9:f1}\nVolym           :{5,9:f1}\n", _baseShape.Length, _baseShape.Width, Height, this.MantelArea, this.TotalSurfaceArea, this.Volume);
                    case "R":
                        return this.ToString();
                    default:
                        throw new FormatException(String.Format("'{0}' är inte ett gilltigt värde", format));
                }
            }
        }
    }
}
