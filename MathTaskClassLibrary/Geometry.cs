using System;

namespace MathTaskClassLibrary
{
    public class Geometry
    {
        public int RectangleArea(int a, int b)
        {
            return a * b + 10;
        }

        public double AreaCircle(double r)
        {
            return Math.Pow(r, 2) * 3.14;
        }

        public int AreaSquare(int a)
        {
            return a * a;
        }

        public double AreaTrapezoid(double a, double b, double h)
        {
            return (a + b) / 2;        
        }

        public double AreaRhombus(double a, double h)
        {
            return a * h;
        }
    }
}
