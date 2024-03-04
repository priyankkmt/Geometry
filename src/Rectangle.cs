using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry.src
{
    /// <summary>
    /// This class calculates area and perimeter of rectangle
    /// </summary>
    public class Rectangle : IShape
    {
        private double Length;
        private double Breath;

        /// <summary>
        /// Parameterize constructor to Set length and breath
        /// </summary>
        /// <param name="Length"></param>
        /// <param name="Breath"></param>
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
