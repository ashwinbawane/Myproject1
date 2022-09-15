using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Aray
{
    class Class1
    {
        static bool isAlreadyPresent(int[] a,int current)
        {
            for (int i = 0; i < current; i++)
            {
                if (a[i] == a[current])
                    
                    return true;


            }

            return false;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 11, 45, 89, 45 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                Console.WriteLine();

                for ( i = 0; i < arr.Length; i++)
                {
                    if(isAlreadyPresent(arr, i) == false)
                    {
                        int c = 1;
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            c++;
                        }
                        Console.WriteLine($"Frequency of {arr[i]} = {c}");
                    }

                    
                }

            }
        }
    }
}
