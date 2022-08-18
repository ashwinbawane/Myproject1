using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Logical_Programs
{
    class LogicPrime
    {
     public  bool IsPrime(int num)

        {
            bool isPrime = true;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;

                
            }
        
       
      
         static void Main(string []args)
        {
            LogicPrime p = new LogicPrime();
            Console.WriteLine("Enter any no");
            int num = int.Parse(Console.ReadLine());
            bool b = p.IsPrime(num);

                if(b == true)
                {
                    Console.WriteLine("Prime");
                }

                else
                {
                    Console.WriteLine("Not prime");
                }




        }
    }
}
