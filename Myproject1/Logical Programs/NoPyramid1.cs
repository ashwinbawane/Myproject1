using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Logical_Programs
{
    class NoPyramid1
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a lines");
            int lines = int.Parse(Console.ReadLine());

            for(int i=1; i<=lines; i++)
            {
               for(int space = i; space <= lines-i; space++)
               {
                    Console.Write("-");
               }

               for(int c = i; c <= 5; c++)
                {
                    Console.Write(c);
                }

                Console.WriteLine();

            }
        }
    }
}
