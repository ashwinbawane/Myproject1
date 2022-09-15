using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST2
{
    class Ano
    {
        static void Main(String[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    if(i % 2 == 1)
                   
                   Console.Write(j);

                    else
                    {
                        Console.Write((char)(64 + j));
                    }
                }

                Console.WriteLine();
            }

            for (int i = 2; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 == 1)

                        Console.Write(j);

                    else
                    {
                        Console.Write((char)(64 + j));
                    }
                }

                Console.WriteLine();
            }



        }
    }
}
