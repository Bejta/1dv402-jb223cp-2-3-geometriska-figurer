using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03A
{
    public abstract class Shape
    {
        //fields
        private double _length;
        private double _width;

        //properties
        public abstract double Area { get; }
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
        public abstract double Perimeter { get; }
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
        //Constructor
        protected Shape(double length, double width)
        {
            _length = length;
            _width = width;
        }
        public override string ToString()
        {
            return String.Format("Längd  :{0,9:f1}\nBredd  :{1,9:f1}\nOmkrets:{2,9:f1}\nArea   :{3,9:f1}\n", Length, Width, Perimeter, Area);
        }
    }
    enum ShapeType
    {
        Elipse,
        Rectangle
    }
}
