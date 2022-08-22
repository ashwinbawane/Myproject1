using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.For_Loop
{
    class OneHundred
    {
        static void Main(String[] args)
        {
            
            for(int i =1; i <= 100; i++)
            {
                if( i % 5 != 0 || i % 10 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
