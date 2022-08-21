using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.For_Loop
{
    class Oddsquare
    {
        static void Main(String[] args)
        {
           for(int i = 1; i <= 50; i++)
           {
                if (i % 2 == 0 && i % 2 != 0)
                {
                    //Console.WriteLine(i);
                    //Console.WriteLine(i  = +i * i);
                }
                
                
                
                Console.WriteLine(i);
                Console.WriteLine( i * i);


                /*else if (i < 0)
                {
                    Console.WriteLine(i * i);
                }

                else
                {
                    Console.WriteLine();
                }*/
            } 
        }
    }
}
