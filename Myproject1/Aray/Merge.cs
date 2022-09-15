using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Aray
{
    class Merge
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 22, 23, 24, 25 };
            int[] b = { 2, 4, 6, 8, 9 };
            int[] c = new int[a.Length + b.Length];

            int k = 0;
            for(int i=0; i < a.Length; i++)
            {
                c[k] = a[i];
                k++;
            }

            for(int i=0; i< b.Length; i++)
            {
                c[k] = b[i];
                k++;
            }

            for(int i=0; i<c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }



        }
    }
}
