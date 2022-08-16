using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1
{
    class Greater
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter 1st no");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd no");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 3rd no");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Num1 is greater");
            }

            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Num2 is greater");
            }

            else 
            {
                Console.WriteLine("Num3 is greater");
            }






        }


    }
}
