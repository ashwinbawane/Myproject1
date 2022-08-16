using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Conditional_Programs
{
    class Compare
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter 1st no");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd no");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Num1 is greater");
            }

            else
            {
                Console.WriteLine("Num2 is greater");
            }
        }
    }
}
