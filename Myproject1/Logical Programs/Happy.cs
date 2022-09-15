using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Method_Overloading
{
    class Happy
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");
            int n = int.Parse(Console.ReadLine());

            int next = n % 10;
            n = n / 10;

            bool isIncreasing = true, isDecreasing = true;

            while (n > 0)
            {
                int prev = n % 10;
                if(prev < next)
                {
                    isDecreasing = false;
                }
                if (prev > next)
                {
                    isIncreasing = false;
                }

                next = prev;
                n = n / 10;


            }
        }
    }
}
