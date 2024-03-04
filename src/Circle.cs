using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.src
{
    internal class Circle : IShape
    {
        private double Radius;
        private readonly double PI = Math.PI;

        /// <summary>
        /// Parameterize constructor to set radius
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double area()
        {
            return PI * Radius * Radius ;
        }

        public double perimeter()
        {
            return 2*PI * Radius ;
        }
    }
}
