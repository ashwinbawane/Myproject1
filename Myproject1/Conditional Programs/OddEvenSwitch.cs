using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Conditional_Programs
{
    class OddEvenSwitch
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter any no");
            int num = int.Parse(Console.ReadLine());

            switch (num % 2) 
            {

                case 0:
                    
                    Console.WriteLine("No is even ");
                    break;

                case 1:
                    
                    Console.WriteLine("No is odd ");
                    break;

               
                    
                        
                    

                        
                    
                    

                        
            }
        }

                
    }
}
