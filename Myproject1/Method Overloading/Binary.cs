using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Method_Overloading
{
    class Binary
    {
        static void Main(String[] args)
        {
            int  r;
            Console.WriteLine("Enter any no");
            int num = int.Parse(Console.ReadLine());
            
            string result = string.Empty;
            while (num > 0)
            {

                r = num % 2;
                 result = Convert.ToString(r) + result;
                num = num / 2;
                
            }
            Console.WriteLine(result);

            Console.ReadLine();

         
        }
    }
}
