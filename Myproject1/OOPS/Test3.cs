using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS
{
    class Sayam
    {
        static void Main(String[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter Five elements");
            for(int i=0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
