using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1
{
    class PosiNega
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");

            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("No is positive");
            }

            else if (num < 0)
            {
                Console.WriteLine("No is negative");
            }

            else if (num == 0)
            {
                Console.WriteLine("No is zero");
            }
        }

           
    }
}
