using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST_3
{
    class Whis
    {
        string name;

        public Whis()
        {
            Console.WriteLine("I am in this keyword");
        }

        public Whis(string name)
        {
            this.name = name;

            
        }


        
    }

    class Test5
    {
        static void Main (String[] args)
        {
            Whis w = new Whis();

            Whis w1 = new Whis();
            

        }
    }
}
