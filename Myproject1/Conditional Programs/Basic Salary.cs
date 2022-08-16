using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Conditional_Programs
{
    class Basic_Salary
    {
       static void Main(String[] args)
        {
            Console.WriteLine(" Enter Basic Salary");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter HRA ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter DA");
            int num3 = int.Parse(Console.ReadLine());



             if (num1 <= 10000)
            {
                Console.WriteLine("HRA is  " + (num1 * num2) / 100);
                Console.WriteLine("DA is  " + (num1 * num3) / 100);
            }

            else if (num1 <= 20000)
            {
                Console.WriteLine("HRA is " + (num1 * num2) / 100);
                Console.WriteLine("DA is " + (num1 * num3) / 100);
            }

            else
            {
                Console.WriteLine("HRA is " + (num1 * num2) / 100);
                Console.WriteLine("DA is " + (num1 * num3) / 100);
            }


            int num4 =  (num1 + num2 + num3);
            Console.WriteLine("Gross salary is " + num4);







        }
    }
}
