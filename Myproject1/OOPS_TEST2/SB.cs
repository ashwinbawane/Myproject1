using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST2
{
    interface Cake 
    { 
        public void bake()
        {

        }
    
    }

    class Strawberry : Cake
    {
        public void bake()
        {
            Console.WriteLine("Nothing");
        }
    }

    class Blackforest : Cake
    {
        public void bake()
        {
            Console.WriteLine("Yes");
        }
    }

















    class SB
    {
    }
}
