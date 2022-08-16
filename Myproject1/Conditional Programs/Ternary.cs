using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Conditional_Programs
{
    class Ternary
    {
      static void Main(String[] args)
        {
            Console.WriteLine("Enter 1st no");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd no");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 3rd no");
            int num3 = int.Parse(Console.ReadLine());

            string str1 = num1 > num2 && num1 > num3 ? "Num1 is greater" : "";
            Console.WriteLine(str1);

            string str2 = num2 > num3 && num2 > num1 ? "Num2 is greater" : "";
            Console.WriteLine(str2);

            string str3 = num3 > num1 && num3 > num2 ? "Num3 is greater" : "";
            Console.WriteLine(str3);


                
        } 
    }
}
