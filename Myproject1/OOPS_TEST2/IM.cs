using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST2
{

    interface Icecream
    {
        public void eat()
        {

        }

        public void juice()
        {

        }

        public void drink()
        {

        }

    }

    class Mastani : Icecream
    {
        public void eat()
        {
            Console.WriteLine("Eat");
        }

        public void juice()
        {
            Console.WriteLine("juice");
        }
    }

    class IM
    {
        static void Main(String[] args)
        {
            Icecream i = new Mastani();
            i.eat();
            i.juice();

        }
    }
















    
}
