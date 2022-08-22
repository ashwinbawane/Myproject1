using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.For_Loop
{
    class Pyramid
    {
        static void Main(String[] args)
        {
            for (int i = 1; i <=5; i++)
            {
                for(int j=2; j<=i; j++)
                {
                    Console.Write(" ");
                }

                for(int k = i; k <= 4; k++)
                {
                    Console.Write("*");
                }

                for(int l = i; l <= 5; l++)
                {
                    Console.Write("*");
                }



                Console.WriteLine();

               
            }
            
        }
    }
}
