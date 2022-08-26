using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS
{
    class Overloading
    {
        public void area(int l ,int b)
        {
            int area = l * b;
            Console.WriteLine("Area of rectangle is " + area);

        }

        public void area(float r)
        {
            float area = (3.14f * r * r);
            Console.WriteLine("Area of circle is " + area);
        }

        public void area (int side)
        {
            int area = side * side;
            Console.WriteLine("Area of square " + area);

        }

        static void Main(String[] args)
        {
            Overloading o = new Overloading();

            o.area(45);
        }







    }
}
