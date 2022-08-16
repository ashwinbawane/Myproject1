using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1
{
    class Divisible
    {
        static void Main(String[] args)
        {
            
            Console.WriteLine("Enter any no");
            
            int num = int.Parse(Console.ReadLine());

            if (num % 5 == 0)
            {
                Console.WriteLine("Divisible by 5");
            }

            else
            {
                Console.WriteLine("Not divisible by 5");
            }

        }
        
    }
}
