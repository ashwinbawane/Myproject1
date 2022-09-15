using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Aray
{
    class Prog9
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 7, 96, 45, 74, 3 };

            int e = 0, o = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] % 2 == 0)
                {
                    e++;
                }

                else
                {
                    o++;
                }

            }

            int[] even = new int[e];
            int[] odd = new int[o];

            e = 0;
            o = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    even[e] = a[i];

                }

                else
                {
                    odd[o] = a[i];
                }

            }

            Console.WriteLine("Even no is "  );

            


        }
    }
}
