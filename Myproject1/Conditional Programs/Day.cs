﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Conditional_Programs
{
    class Day
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a no from 1 to 7");
            int num = int.Parse(Console.ReadLine());

            


            switch (num)
            {
             case 1:Console.WriteLine("Monday");
                    break;
            case 2: Console.WriteLine("Tuesday");
                    break;
            case 3: Console.WriteLine("Wednesday");
                    break;
            case 4: Console.WriteLine("Thursday");
                    break;
                case 5: Console.WriteLine("Friday");
                    break;
                case 6: Console.WriteLine("Saturday");
                    break;
                case 7: Console.WriteLine("Sunday");
                    break;

                
            }

                
        }
    }
}
