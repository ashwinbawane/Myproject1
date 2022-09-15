using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Aray
{
    class Divide
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 elements");


            int[] a = new int[5];


            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

                if(a[i] % 5 == 0)
                {
                    a[i] = a[i] + 5;
                }

                Console.WriteLine(a[i]);

            }

            
        }
    }
}
