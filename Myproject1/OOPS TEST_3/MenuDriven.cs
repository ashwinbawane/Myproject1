using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST_3
{
    class MenuDriven
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter 1st no");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2nd no");
            int num2 = int.Parse(Console.ReadLine());

            double area = 0;

            Console.WriteLine("1.Area of circle \n2. Area of rectangle \n3. Area of square ");
            Console.WriteLine("Enter your choice");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Area of circle is ");
                    
                    area = 3.14 * num1 * num1;
                    break;
                case 2:
                    Console.WriteLine("Area of rectangle is ");
                    
                    
                    area = num1 * num2;
                    break;
                case 3:
                    Console.WriteLine("Area of square is ");
                    
                   
                   
                    area = num1 * num1;
                    break;
            }
            Console.WriteLine(area);

        }
    }
}
