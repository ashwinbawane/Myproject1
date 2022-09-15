using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST_3
{
    class Count
    {
        public void Number(int num, int d)
        {
            int c = 0;

            while (num > 0)
            {


                if (num % 10 == d)
                    c++;

                num = num / 10;
                
            }

            Console.WriteLine("Frequency is" + c);

        }

        public void Number(int n1)
        {
            int sum = 0;
            for (int i = 2; i <= n1; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;



                }

            }
            Console.WriteLine(sum);


        }

        static void Main(String[] args)
        {
            Count c = new Count();
            Console.WriteLine("Enter 1st no");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd no");
            int num2 = int.Parse(Console.ReadLine());

            c.Number(num1, num2);
            c.Number(num1);
            
        }
            
    }
}
