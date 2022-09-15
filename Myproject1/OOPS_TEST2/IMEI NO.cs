using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST2
{
    class IMEI_NO
    {
       static void Main(String[] args)
        {
            Console.WriteLine("Enter a no");
            long n = long.Parse(Console.ReadLine());

            int c = 0;
            long copy = n;

            while (n > 0)
            {
                n = n / 10;
                c++;
            }

            if (c != 15)

                Console.WriteLine("Invalid IMEI no");
            else
            {
                int sum = 0;
                n = copy;
                c = 0;
                while (n > 0)
                {
                    int r = (int)(n % 10);
                    c++;

                    if(c % 2 == 0)
                    {
                        int doubleup = 2 * r;
                        sum = sum + doubleup % 10 + doubleup / 10;
                    }

                    else
                    {
                        sum = sum + r;
                    }
                }

                if (sum % 10 == 0)

                    Console.WriteLine("Valid IMEI no");
                else
                    Console.WriteLine("Not IMEI no");
            }
            

        }
    }
}
