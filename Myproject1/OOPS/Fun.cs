using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS
{
    class Fun
    {
        public string check(int a)
        {
            if(a % 5 == 0)
            {
                return "yes";
            }

            else
            {
                return "no";
            }
            


        }
        
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");
            int n = int.Parse(Console.ReadLine());

            Fun f = new Fun();
            string s = f.check(n);

            if (true)
            {
                Console.WriteLine("Divisible by 3");
            }

           


        }
    }
}
