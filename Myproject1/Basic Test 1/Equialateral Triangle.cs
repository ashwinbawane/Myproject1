using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Basic_Test_1
{
    class Equialateral_Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side of an equilateral triangle");
            int num1 = int.Parse(Console.ReadLine());

            
            
           int num2 = (3 * num1 * num1) / 4;

            Console.WriteLine("Area of an equilateral triangle is " + num2);
        }
    }
}
