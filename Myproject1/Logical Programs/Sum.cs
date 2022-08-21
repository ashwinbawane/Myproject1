using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Logical_Programs
{
    class Sum
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");
            int n = int.Parse(Console.ReadLine());

            int sum = 1, a = 0;
            
            for(int i = 1; i <= n; i++)
            {
                sum = sum * i;

                 a = a + sum;
                
            }

            Console.WriteLine(a);
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            /*Console.WriteLine("Enter any no");
            int num = int.Parse(Console.ReadLine());
            int sum ;
            for(int i = 1; i <= num; i++)
            {
                sum = num + num;
                Console.WriteLine(sum);
            }
            //Console.WriteLine(sum);*/
        }
    }
}
