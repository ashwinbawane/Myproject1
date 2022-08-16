using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1
{
    class TernaryOperator
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");
            int num = int.Parse(Console.ReadLine());

            String ans = num >= 0 ?  "Num is positive" : "Num is negative";
            Console.WriteLine(ans);
        }
    }
}
