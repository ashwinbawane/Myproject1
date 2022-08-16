using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Conditional_Programs
{
    class Vowel
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the char");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Vowel");
            }

            else
            {
                Console.WriteLine("Consonent");
            }
        }
    }
}
