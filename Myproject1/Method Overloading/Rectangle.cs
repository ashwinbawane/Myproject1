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

        public void input(int l, int b)
        {
            length = l;
            breadth = b;
            

        }

        public void calculate()
        {
            
             area = length * breadth;
             perimeter= 2 * length + 2 * breadth;
        }

        public void display()
        {
            Console.WriteLine("Area is " +area);
            Console.WriteLine("Perimeter is " + perimeter);
        }


      static void Main(String[] args)
        {
            Console.WriteLine("Enter length");
            int w = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter breadth");
            int s = int.Parse(Console.ReadLine());

          
            Rectangle r = new Rectangle();
            r.input(w, s);

            r.calculate();
            r.display();



        }


    }
}
