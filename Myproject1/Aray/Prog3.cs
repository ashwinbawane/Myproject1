using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Aray
{
    class Prog3
    {
        static void Main(string[] args)
        {
            int[] a = { 8, 5, 9, 56, 85, 45, 4 };

            int e = 56 ;

            int l = a.Length;

            int i = 0;
            while(i < l)
            {
                if(a[i] == e)
                {
                    i += i;
                   
                }
                

            }

            Console.WriteLine(e + "Index found " + i);
        }
    }
}
