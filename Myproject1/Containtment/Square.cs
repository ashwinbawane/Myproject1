using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Containtment
{
    class Square
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i < n; i++)
            {
                 sum  = i * i;
                Console.WriteLine(sum);

            }
            
            
        }
    }
}
