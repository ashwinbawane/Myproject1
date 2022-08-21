using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.For_Loop
{
    class EvenDigit
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                if ( i % 2 == 0)
                {
                    sum = sum + i;
                   


                }

            }
            Console.WriteLine(sum);

        }
    }
}
