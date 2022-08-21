using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Logical_Programs
{
    class Star
    {
        static void Main(String[] args)
        {
            //Console.WriteLine("Enter 1st no");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter 2nd no");
            //int num2 = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                for( int j = 1; j <= 10; j++)
                {
                    if (i == 1 || i == 5 || i == 10 || j == 1)
                    {
                        Console.Write("*");
                            
                    }


                    else
                    { 
                        Console.Write(" ");
                    }
                    
                   
                        
                }

                Console.WriteLine();
                
            }
            
        }
    }
}
