using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Conditional_Programs
{
    class Digits
    {
        static void Main(String[] args)
        {
            /* Console.WriteLine("Enter 1st no");
             int num1 = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter 2nd no");
             int num2 = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter 3rd no");
             int num3 = int.Parse(Console.ReadLine());

             int sum = num1 + num2 + num3;
             Console.WriteLine("Sum is  " + sum); */

            Console.WriteLine("Enter 3 digit no");
            int num = int.Parse(Console.ReadLine());

            int sum = num + num + num;
            Console.WriteLine("Sum is " + sum);
        }
    }
}
