using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Conditional_Programs
{
    class Simple_Calculator
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter 1st no");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd no");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("1.Addition \n2. Subtraction \n3. Multiplication \n4. Division ");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: Console.WriteLine("Addition " + (num1 + num2));
                    break;

                case 2: Console.WriteLine("Subtraction " + (num1 - num2));
                    break;

                case 3: Console.WriteLine("Multiplication " + (num1 * num2));
                    break;

                case 4: 
                    if (num2 != 0)
                    {
                        Console.WriteLine("Divison " + (num1 / num2));
                    }

                    else
                    {
                        Console.WriteLine("Not divisible");
                    }
                    break;

            }
        }
    }
}
