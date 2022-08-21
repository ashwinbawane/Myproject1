using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Logical_Programs
{
    class Fabbo
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");
            int n = int.Parse(Console.ReadLine());


            int num1 = 0, num2 = 1, num3;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(num1);
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
            }

            Console.ReadLine();

                       

            
        }
    }
}
