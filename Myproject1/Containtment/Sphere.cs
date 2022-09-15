using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Containtment
{
    class Sphere
    {
        public double volume(double r)
        {
            double v = 4/3 * 22 / 7 *r;
            return v;

        }

        public double volume (double h, double r)
        {
            double v = 22 / 7 * r * h;
            return v;
        }

        public double volume ( double l, double b, double h)
        {
            double v = l * b * h;
            return v;
        }

        static void Main(String[] args)
        {
            Sphere s = new Sphere();

            double d = s.volume(5,6,8);

            Console.WriteLine("Volume of sphere is " + d);



        }
    }
}
