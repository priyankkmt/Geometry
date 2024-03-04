using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.src
{
    /// <summary>
    /// It handles the responsibility of creating diffrent shapes instances and returns them 
    /// </summary>
    internal class ShapeFactory
    {
        /// <summary>
        /// It will return instance of rectangle class
        /// </summary>
        /// <param name="Length"></param>
        /// <param name="Width"></param>
        /// <returns></returns>
        public static IShape CreateRectangle(double Length, double Width)
        {
            return new Rectangle(Length, Width);
        }

        /// <summary>
        /// Return instance of Triangle class
        /// </summary>
        /// <param name="TriangleBase"></param>
        /// <param name="Length"></param>
        /// <returns></returns>
        public static IShape CreateTriangle(double TriangleBase, double Length)
        {
            return new Triangle(TriangleBase, Length);
        }

        /// <summary>
        /// Return instance of Circle class
        /// </summary>
        /// <param name="Radius"></param>
        /// <returns></returns>
        public static IShape CreateCircle(double Radius)
        {
            return new Circle(Radius);
        }
    }
}
