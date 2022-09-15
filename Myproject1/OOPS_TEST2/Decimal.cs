using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST2
{
    class Decimal
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dec = 0, baseval = 1, rem;

            while (n > 0)
            {
                rem = n % 10;
                n = n / 10;
                dec = dec + rem * baseval;
                baseval = baseval * 2;
            }

            Console.WriteLine(dec);
            Console.ReadLine();
        }
    }
}
