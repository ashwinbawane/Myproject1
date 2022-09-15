using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST_3
{
    class Coverloading
    {
        public Coverloading()
        {
            Console.WriteLine("I am in default constructor");
        }

        public Coverloading(int a)
        {
            Console.WriteLine(a);
        }

        static void Main(String[] args)
        {
            Coverloading c = new Coverloading();

            Coverloading c1 = new Coverloading(23);
            
        }
    }
}
