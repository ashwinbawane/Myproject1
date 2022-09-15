using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST_3
{
    class Npattern
    {
        static void Main(String[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = i; k <= 5; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();


            }
        }
    }
}
