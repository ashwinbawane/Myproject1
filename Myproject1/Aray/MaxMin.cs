using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Aray
{
    class MaxMin
    {
        static void Main(String[] args)
        {
            int[] a = { 54, 89, 63, 444, 85 };

            int max = a[0]; 
            int min = a[0];

        for (int i = 0; i<a.Length; i++)
	    {
                if(a[i] > max)
                {
                     max = a[i];
                }
        }

         for (int i = 0; i < a.Length; i++)
         {
                if (a[i] < min)
                {
                    min = a[i];
                }
         }

            Console.WriteLine("Maximun element is " + max);
            Console.WriteLine("Minimum element is " + min);
      }
    }
}
