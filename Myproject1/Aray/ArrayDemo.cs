using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Aray
{
    class ArrayDemo
    {
        static void Main(String[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter Five elements");
            for (int i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] % 5 == 0)

                {
                    a[i] = a[i] + 5;
                    Console.WriteLine(a[i]);



                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }

            for(int i = 0; i <= 9; i++)
            {

                if (a[i] % 2 == 0)
                {
                    
                    Console.WriteLine(a[i]);
                }

                int count = 0;
                
                if(a[i] % 5 == 0)

                {
                    a[i] = a[i] + 5;
                    count++;
                    
                    
                    
                }
            }





        }
    }
}
