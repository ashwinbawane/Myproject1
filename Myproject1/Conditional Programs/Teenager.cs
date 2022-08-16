using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Conditional_Programs
{
    class Teenager
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter age");
            int num = int.Parse(Console.ReadLine());

            if (num < 18)
            {
                Console.WriteLine("He is a teenager");
            }

            else
            {
                Console.WriteLine("He is not a teenager");
            }

        }
    }
}
