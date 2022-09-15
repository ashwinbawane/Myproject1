using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Containtment
{
    class P
    {
        int i;

        public P(int i)
        {
            this.i = i;

            Console.WriteLine("yes");
        }
        
        public P()
        {
            Console.WriteLine("class p");
        }
    }

    class C : P
    {
        int k;

        public C(int k, int i)
        {
            this.k = k;
            
            
           

            Console.WriteLine("test");
        }

        public C():base()
        {
            Console.WriteLine("class c");
        }
    }


    class Test
    {
        static void Main(string[] args)
        {
            C c = new C(12, 13);
        }
    }
}
