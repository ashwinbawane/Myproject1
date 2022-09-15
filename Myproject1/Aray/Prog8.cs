using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Aray
{
    class Prog8
    {
        static void Main(string[] args)
        {
            int[] a = new int[8];
            Console.WriteLine("Enter elements");

            for(int i=0; i<a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

                
            }

            for(int i=0; i < a.Length; i++)
            {
                int nega = 0;

                if(a[i] < nega)
                {
                    nega++;
                    Console.WriteLine("Negative no is " + a[i]);
                }
            }

            Console.WriteLine(" ");

            
        }
    }
}
