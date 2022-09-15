using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Containtment
{
    class Fabbonici
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter 1st no");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd no");
            int b = int.Parse(Console.ReadLine());

            int c;

            for (int i = 0; i < 10; i++)
            {
                c = a + b;

                a = b;
                b = c;

                Console.WriteLine(c);
            }

            Console.ReadLine();



        }
    }
}
