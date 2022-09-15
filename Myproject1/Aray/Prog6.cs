using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Aray
{
    class Prog6
    {
        public static int average(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];

            }

            return sum = sum / a.Length;

        }

        public static double average (double[] a)
        {
           double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];

            }
            return sum = sum / a.Length;

        }

        static void Main(String[] args)
        {
            int[] a = { 2, 4, 5, 6, 8, 52 };
            double[] b = { 5.4, 5.8, 63, 45 };

            int c = average(a);

            double d = average(b);

            Console.WriteLine("Avrage is" + c);
            Console.WriteLine("Average is" + d);
        }
    }
}
