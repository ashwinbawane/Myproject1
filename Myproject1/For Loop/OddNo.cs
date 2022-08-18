using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.For_Loop
{
    class OddNo
    {
        static void Main(String[] args)
        {
            

            for(int i = 15; i <= 35; i++)
            {
                if ( i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
