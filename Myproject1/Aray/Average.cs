using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Aray
{
    class Average
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 elements");
            

            int []a = new int[5];

            int sum = 0;

            for(int i=0; i< a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                sum = sum + a.Length;

            }

            double average = sum / a.Length;
            Console.WriteLine(average + " ");



        }
    }
}
