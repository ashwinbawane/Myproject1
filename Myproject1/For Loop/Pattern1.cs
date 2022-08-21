using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.For_Loop
{
    class Pattern1
    {
        static void Main(String[] args)
        {
            for(int i =1; i <= 5; i++)
            {
                for ( int j = 2; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for(int k = i; k <= 5; k++)
                {
                    Console.Write(" ");
                }

                for(int l = i; l <= 4; l++)
                {
                    Console.Write("1");
                }

                Console.WriteLine(" ");

            }
        }
    }
}
