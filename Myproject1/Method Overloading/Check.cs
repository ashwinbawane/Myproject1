using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Method_Overloading
{
    class Check
    {
        public bool isEven(int n)
        {
            if(n % 2 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }



        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");
            int a = int.Parse(Console.ReadLine());
            Check c = new Check();

            bool b = c.isEven(a);

            if(b == true)
            {
                Console.WriteLine("No is even");
            }

        }





    }
}
