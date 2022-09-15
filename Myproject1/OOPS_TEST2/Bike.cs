using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST2
{
    

        interface calculator
        {
            void add(int a, int b);
            void subtract(int a, int b);
        }

        class MyCalculator : calculator
        {
            public void add(int a, int b)
            {
            throw new NotImplementedException();
            }

            public void subtract (int a, int b)
            {
            throw new NotImplementedException();
            }


        }

    class Bike
    {
        static void Main(String[] args)
        {
            calculator c = new MyCalculator();
            c.add(9,8);
            c.subtract(5, 4);
        }
    }
    
}
