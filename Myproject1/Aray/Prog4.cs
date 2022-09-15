using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Aray
{
    class Prog4
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 8, 7, 6, 23, 45, 46 };

            int[] b = new int[7];

            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
                
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Element is " + b[i]);
            }

        }
    }
}
