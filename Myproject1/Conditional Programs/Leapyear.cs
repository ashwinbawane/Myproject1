using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Conditional_Programs
{
    class Leapyear
    {
        static void Main(String[] args)
        {
            Console.WriteLine(" Enter a year");
            int num = int.Parse(Console.ReadLine());

            if ( num % 400 == 0 || num % 4 == 0)
            {
                Console.WriteLine("It's leap year");
            }

            else 
            {
                Console.WriteLine("It's not leap year");
            }

            
        }
    }
}
