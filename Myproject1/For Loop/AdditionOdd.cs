﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.For_Loop
{
    class AdditionOdd
    {
        static void Main(String[] args)
        {

            int sum = 0;

           
            for(int i = 1; i <=20; i++)
            {
                if ( i % 2 != 0)
                {
                   
                     
                    

                    sum = sum + i;
                    Console.WriteLine(sum);
                    
                }
            }
        }
    }
}
