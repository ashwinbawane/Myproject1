using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Aray
{
    class Merge2
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 25, 29, 42, 25 };
            int[] b = { 2, 4, 6, 8, 9 };
            int[] c = new int[a.Length + b.Length];

            int k = 0;
            for (int i = 0; i < c.Length;)
            {
                if(k < a.Length && k < b.Length)
                {
                    c[i] = a[k];
                    i++;

                    c[i] = b[k];
                    i++;
                }

                else if (k < b.Length)
                {
                    c[i] = b[k];
                    i++;

                }

                else if(k < a.Length)
                {
                    c[i] = a[k];
                    i++;
                }

                k++;

              
            }

            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }

            
        }
    }
}
