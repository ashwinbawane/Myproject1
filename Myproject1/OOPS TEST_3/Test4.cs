using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST_3
{
    class Degree
    {
       
        public void get_degree()
        {
            Console.WriteLine("I got degree");
        }

        public Degree()
        {

        }

    }

    class Undergraduate
    {
        public void get_degree()
        {
            Console.WriteLine("I am an undergraduate");
        }
    }

    class PostGraduate
    {
        public void get_degree()
        {
            Console.WriteLine("I am an postgraduate");
        }
    }

    class Test4
    {
        static void Main(String[] args)
        {
            Degree d = new Degree();
            Undergraduate u = new Undergraduate();
            PostGraduate p = new PostGraduate();

            d.get_degree();
            u.get_degree();
            p.get_degree();
        }
    }
}
