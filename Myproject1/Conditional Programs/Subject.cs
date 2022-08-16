using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Conditional_Programs
{
    class Subject
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter marks of five subject");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());
            

             float num6 = (num1 + num2 + num3 + num4 + num5);
            Console.WriteLine("Total is " + num6);

             float num7 = (num6 / 5);
            Console.WriteLine("Average is " + num7);

             float num8 = (num6 / 500) * 100 ;
            Console.WriteLine(" Percentage is " + num8);


        }
    }
}
