using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Method_Overloading
{
    class Rectangle
    {
        int length;
        int breadth;
        int area;
        int perimeter;

        public void input(int l, int b, int a, int p)
        {
            length = l;
            breadth = b;
            area = a;
            perimeter = p;

        }

        public void calculate(int l, int b)
        {
            length = l;
            breadth = b;
             int a = length * breadth;
             int p = 2 * length + 2 * breadth;
        }

        public void display()
        {
            Console.WriteLine("Area is " + length * breadth);
            Console.WriteLine("Perimeter is " + (2*length + 2*breadth));
        }


      static void Main(String[] args)
        {
            Console.WriteLine("Enter length");
            int w = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter breadth");
            int s = int.Parse(Console.ReadLine());

          
            Rectangle r = new Rectangle();

            r.calculate(w,s);
            r.display();



        }


    }
}
