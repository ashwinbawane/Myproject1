using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST_3
{
    class Character
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any char");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'A' && ch <= 'Z')
                Console.WriteLine("Upper case");

            else if (ch >= 'a' && ch <= 'z')
                Console.WriteLine("Lower case");

            else
                Console.WriteLine("Not a charcter ");
                        
        }
    }
}
