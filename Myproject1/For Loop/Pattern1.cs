using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.For_Loop
{                                                                      //1
                                                                  //2222
    class Pattern1
    {
        static void Main(String[] args)
        {
            for(int i =1; i <= 4; i++)
            {
                for ( int j = i; j <= 4; j++)
                {
                    Console.Write(" ");
                }

                for(int k = 1; k <= i; k++)
                {
                    Console.Write(i);
                }

                for(int l = 2; l <= i; l++)
                {
                    Console.Write(i);
                }

                Console.WriteLine(" ");

            }
        }
    }
}
