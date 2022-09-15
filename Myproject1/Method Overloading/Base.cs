using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Method_Overloading
{
    class Base
    {
        public int Power(int x, int y)
        {
            int index = 1;
            
            for(int i = 1; i<=y; i++)
            {
                index = index * x;


            }

            return index;
        }


        static void Main(String[] args)
        {
            Console.WriteLine("Enter base");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter index");
            int i = int.Parse(Console.ReadLine());

            Base b = new Base();

            int c = b.Power(a, i);

            Console.WriteLine(c);


        }
    }
}
