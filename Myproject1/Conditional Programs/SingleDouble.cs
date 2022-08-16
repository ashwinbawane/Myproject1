using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Conditional_Programs
{
    class SingleDouble
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a digit");
            int num = int.Parse(Console.ReadLine());



            if (num >= 0 && num <= 9)
            {
                Console.WriteLine("It's a single digit");
            }
            else
            {
                Console.WriteLine("It's a double digit");
            }

           
        }
    }
}
