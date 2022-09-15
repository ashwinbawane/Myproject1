using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Aray
{
    class Add
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter elements in array");
            int[] a = new int[5];

            for(int i=0;i<a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());


            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
        }
    }
}
