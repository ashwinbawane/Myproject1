using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Conditional_Programs
{
    class Special_Alpha_Digit
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a character");
            char ch = Convert.ToChar(Console.ReadLine());

            if ( ch >='A' && ch <= 'Z')
            {
                Console.WriteLine(" Alphabet");
            }
             else if( ch >= 'a' && ch<='z')
            {
                Console.WriteLine("Alphabet");
            }

            else if(ch >= '0' && ch<= '9')
            {
                Console.WriteLine("Digit");
            }

            else
            {
                Console.WriteLine("Symbol");
            }


            
        }
    }
}
