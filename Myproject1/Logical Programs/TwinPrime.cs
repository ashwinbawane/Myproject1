using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Logical_Programs
{
    class TwinPrime
    {
        public bool IsPrime(int n)
        {
                 int c = 0;
                for(int i = 2; i <=n/2; i++)
                {
                  if(n % i == 0)
                  {
                    c = 1;
                    break;
                  }
                }

            if (c == 0)
                return true;
            else
                return false;

        }
       
        
          static void Main(String[] args)
        {
            TwinPrime t = new TwinPrime();
            Console.WriteLine("Enter two no");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            bool b1 = t.IsPrime(num1);
            bool b2 = t.IsPrime(num2);

            if(b1 == true && b2 == true)
            {
                if(num1 - num2 == 2 || num2 - num1 == 2)
                
                    Console.WriteLine(" Twin prime");
                    else
                    Console.WriteLine("Only prime not twins");
            }

            else
            {
                Console.WriteLine("Not prime");
            }


        }
    }
}
