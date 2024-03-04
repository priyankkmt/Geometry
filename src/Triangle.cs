using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.src
{
    internal class Triangle : IShape
    {
        private double TriangleBase;
        private double Height;

        /// <summary>
        /// Parameterize constructor to set TriangleBase and height
        /// </summary>
        /// <param name="TriangleBase"></param>
        /// <param name="Height"></param>
        public Triangle(double TriangleBase, double Height)
        {
            this.TriangleBase = TriangleBase;
            this.Height = Height;
        }

        public double area()
        {
            return (TriangleBase * Height) / 2;
        }

        public double perimeter()
        {
            double Hypotenus = CalculateHypotenus();
            return Hypotenus + Height + TriangleBase;
        }

        private double CalculateHypotenus()
        {
            return Math.Sqrt(Height * Height + TriangleBase * TriangleBase); 
        }
    }
}
