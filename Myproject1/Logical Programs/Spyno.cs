using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Logical_Programs
{
    class Spyno
    {
        public bool check(int a)
        {

            int no, sum = 0,
                product = 1;
            while (a > 0)
            {
                no = a % 10;

                
                sum += no;

                
                product *= no;
                a = a / 10;
            }

            
            if (sum == product)
                return true;
            else
                return false;
        }

        static void Main(String[] args)
        {
            Spyno s = new Spyno();
            Console.WriteLine("Enter any digit");
            int n = int.Parse(Console.ReadLine());

           

            bool b = s.check(n);
            if (b == true)
                Console.WriteLine("It is a spy no");

            else
                Console.WriteLine("It is not spy no");
        }
    }
}
