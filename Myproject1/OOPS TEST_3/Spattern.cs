using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST_3
{
    class Spattern
    {
        static void Main(String[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write(j);
                }

                for (int k = i; k <= 5; k++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();


            }
        }
    }
}
