using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Logical_Programs
{
    class Series
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");
            int n = int.Parse(Console.ReadLine());

            int s;
            for(int i = 1; i <= n; i++)
            {
                s = (i * i) + (i * i * i);
                Console.WriteLine(s);
            
            }
           
            
            
        }

      
    }
}
