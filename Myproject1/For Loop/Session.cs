using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.For_Loop
{
    class Session
    {
        static void Main(String[] args)
        {
            for(int i = 8; i>=4; i--)
            {
                for(int j = 8; j>=i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            for(int i = 5; i>=1; i--)
            {
                for(int j = 5; j >= i; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            for(int i = 1; i <=5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }


        }
    }
}
