using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.src
{
    internal class ShapeFactory
    {
        public static IShape CreateRectangle(double Length, double Width)
        {
            return new Rectangle(Length, Width);
        }
        public static IShape CreateTriangle(double TriangleBase, double Length)
        {
            return new Triangle(TriangleBase, Length);
        }
        public static IShape CreateCircle(double Radius)
        {
            return new Circle(Radius);
        }
    }
}
