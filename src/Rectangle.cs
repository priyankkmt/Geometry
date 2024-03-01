using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.src
{
    public class Rectangle : IShape
    {
        private double Length;
        private double Breath;

        public Rectangle(double Length, double Breath)
        {
            this.Length = Length;
            this.Breath = Breath;
        }

        public double area()
        {
            return Length*Breath;
        }

        public double perimeter()
        {
            return 2*(Length+Breath);
        }
    }
}
