using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Conditional_Programs
{
    class Calculator
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter 1st no");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd no");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("1.+ \n2. - \n3. * \n4. / ");
            
            Console.WriteLine("Enter above operator no");
            
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: Console.WriteLine((num1 + num2));
                    break;

                case 2: Console.WriteLine((num1 - num2));
                    break;

                case 3: Console.WriteLine((num1 * num2));
                    break;

                case 4: 
                    if (num1 % num2 == 0 || num2 % num1 ==0)
                    {
                        Console.WriteLine((num1 / num2));
                        break;

                    }
                    Console.WriteLine((num1 / num2));
                    break;






            }

        }
    }
}
