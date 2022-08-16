using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1
{
    class Divide
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");

            int num = int.Parse(Console.ReadLine());

            if (num % 3 == 0 && num % 9 == 0)
            {
                Console.WriteLine("No is divisible by 3 and 9");
            }

            else
            {
                Console.WriteLine("No is not divisible by 3 and 9");
            }

        }
    }
}
