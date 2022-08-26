using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Logical_Programs
{
    class Bigno
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");
            int n = int.Parse(Console.ReadLine());

            int large = 0;
            int small = 11;
            while (n != 0)
            {
                int a = n % 10;
                large = a > large ?
                small = Math.Min(a, small):
                n = n / 10;
            }
            Console.WriteLine("The largest=" + large + "The smallest=" + small);
            
            //int a = n % 10;
           // n = n % 10;
           // while (n > 0) ;







        }
    }
}
