using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Method_Overloading
{
    class Desiarum
    {
            public  int calculate(int n)
            {
                int c = 0;
                while (n != 0)
                {
                    c++;
                    n = n / 10;
                }
                return c;
            }

            public static void Main()
            {

            Console.WriteLine("Enter any no");
            int num = int.Parse(Console.ReadLine());
                Desiarum d = new Desiarum();
                int sum = 0, rem = 0, n;
                int len = d.calculate(num);

                
                n = num;
            //int index = 1;

            //for (int i = 1; i <= y; i++)
            //{
                //index = index * x;


            //}//

            while (num > 0)
                {
                    rem = num % 10;
                    sum = sum + (int)Math.Pow(rem, len);
                    num = num / 10;
                    len--;
                }

                 
                if (sum == n)
                    Console.WriteLine("Desiarum no " + n);
                else
                    Console.WriteLine(" Not a desiarum no " + n);
            }
    }














    
}
