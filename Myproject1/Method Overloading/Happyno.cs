using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Method_Overloading
{
    class Happyno
    {
        static int increasing(int n)
        {
            int d, x, flag = 1;
            while (n > 9)
            {
                d = n % 10;
                x = (n % 100) / 10;
                if(x > d)
                {
                    flag = 0;
                    break;
                }
                n = n / 10;
            }
            return flag;
        }

        static int decreasing(int n)
        {
            int d, x, flag = 1;
            while (n > 9)
            {
                d = n % 10;
                x = (n % 100) / 10;
                if (x < d)
                {
                    flag = 0;
                    break;
                }
                n = n / 10;
            }
            return flag;
        }

        static void Main(String[] args)
        {
            Happyno h = new Happyno();

            Console.WriteLine("Enter any 3 digit no");
            int a = int.Parse(Console.ReadLine());

            if(a < 999)
            {
                Console.WriteLine("Invalid Output");

            }

            else if (increasing(a) == 1)
            {
                Console.WriteLine("Increasing Number");
            }
            else if(decreasing(a) == 1)
            {
                Console.WriteLine("Decreasing number");
            }
            else
            {
                Console.WriteLine("Bouncy no");
            }
        }
    }
}
