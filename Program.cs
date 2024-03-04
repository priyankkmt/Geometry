using Geometry.src;
using System;

namespace Geometry
{
    class GeometryCalculator()
    {
        static void Main(string[] args)
        {
            // Handle Rectangle
            Console.WriteLine("Enter length and breath of rectagle");
            double Length = Convert.ToDouble(Console.ReadLine());
            double Breath = Convert.ToDouble(Console.ReadLine());

            IShape Rectangle = ShapeFactory.CreateRectangle(Length, Breath);
            Console.WriteLine("Area : " + Rectangle.area());
            Console.WriteLine("Perimeter : " + Rectangle.perimeter());

            // Handle Circle
            Console.WriteLine("Enter radius of triangle");
            double Radius = Convert.ToDouble(Console.ReadLine());

            IShape Circle = ShapeFactory.CreateCircle(Radius);
            Console.WriteLine("Area : " + Circle.area());
            Console.WriteLine("Perimeter : " + Circle.perimeter());

            // Handle Triangle
            Console.WriteLine("Enter base and height of triangle");
            double TriangleBase = Convert.ToDouble(Console.ReadLine());
            double Height = Convert.ToDouble(Console.ReadLine());

            IShape Triangle = ShapeFactory.CreateTriangle(TriangleBase, Height);
            Console.WriteLine("Area : " + Triangle.area());
            Console.WriteLine("Perimeter : " + Triangle.perimeter());

        }
    }
}
