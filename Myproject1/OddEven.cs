using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1
{
    class OddEven
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");
            
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("No is even");

            }

            else
            {
                Console.WriteLine("No is odd");
            }
                   
             

        }
    }
}
