using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Containtment
{
    class Diff
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any no");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = i * i + 2;
                Console.WriteLine(sum);

            }

        }
    }
}
