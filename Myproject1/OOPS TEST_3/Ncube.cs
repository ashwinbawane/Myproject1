using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST_3
{
    class Ncube
    {
        public void num(int num, char ch)
        {
            if (ch == 's')
            {
                int square = num * num;
                Console.WriteLine(square);

            }

            else
            {
                int cube = num * num * num;
                Console.WriteLine(cube);
            }


        }

        public void num(int a, int b, char ch)
        {
            if (ch == 'p')
            {
                int prod = a * b;
                Console.WriteLine(prod);
            }

            else
            {
                int add = a + b;
                Console.WriteLine(add);
            }
                
                
        }

        static void Main(String[] args)
        {
            Ncube n = new Ncube();
            Console.WriteLine("Enter char");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter no");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd no");
            int n2 = int.Parse(Console.ReadLine());

            n.num(n1,ch);
            n.num(n1, n2, ch);


        }
    }
}
