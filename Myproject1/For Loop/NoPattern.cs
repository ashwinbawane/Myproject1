using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.For_Loop
{
    class NoPattern
    {
        static void Main(String[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for(int k = i; k <=5; k++)
                {
                    Console.Write(k);
                }

                Console.WriteLine();
                
                
            }
        }
    }
}
