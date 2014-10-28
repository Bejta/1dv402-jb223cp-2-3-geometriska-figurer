using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L03C
{
    /// <summary>
    /// Abstract base class for all shapes
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Determines if Shape is of 3D type
        /// </summary>
        public bool IsShape3D
        {
            get
            {
                switch (ShapeType)
                {
                    case ShapeType.Cuboid:
                    case ShapeType.Cylinder:
                    case ShapeType.Sphere:
                        return true;
                    default:
                        return false;
                }
            }
        }
        public ShapeType ShapeType
        {
            get;
            private set;
        }
        protected Shape (ShapeType shapeType)
        {
            ShapeType = shapeType;
        }
        public abstract string ToString(string format);
    }

    /// <summary>
    /// Enum for all types of shapes
    /// </summary>
    public enum ShapeType
    {
        Rectangle,
        Circle,
        Ellipse,
        Cuboid,
        Cylinder,
        Sphere
    }
}
