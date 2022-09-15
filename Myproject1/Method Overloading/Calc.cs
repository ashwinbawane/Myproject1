using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Method_Overloading
{
    class Calc
    {
        public void num_calc(int num, char ch)
        {
            int sum;
            if(ch == 's')
            {
                sum = num * num;
                Console.WriteLine("square" + sum);
            }
            
        }

        public void num_calc(int a, int b, char ch)
        {
            int sum;
            if(ch == 'p')
            {
                sum = a * b;
            }
            else
            {
                sum = a + b;
            }



        }

        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter char s or p");
            char c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter any no");
            int a = int.Parse(Console.ReadLine());

            Calc ca = new Calc();

            ca.num_calc(n, c);
            ca.num_calc(n, a, c);


        }







    }
}
