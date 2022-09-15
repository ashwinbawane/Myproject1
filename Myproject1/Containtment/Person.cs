using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Containtment
{
    class Person
    {
        int id;
        string name;
        Vehicle v;


        

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }


        class Vehicle
        {
            int vid;
            string vname;


            public int Vid
            {
                set { vid = value; }
                get { return vid; }
            }

            public string Vname
            {
                set { vname = value; }
                get { return vname; }
            }
        }


        
        static void Main(String[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();
            Vehicle v1 = new Vehicle();
            Vehicle v2 = new Vehicle();

            p1.Id = 01;
            p1.Name = "Hasnain";
            p2.Id = 02;
            p2.Name = "Rushi";

            v1.Vname = "Pulsar";
            v1.Vid = 1010;

            Console.WriteLine(p1.Id);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Id);
            Console.WriteLine(p2.Name);

            Console.WriteLine(v1.Vname);
            Console.WriteLine(v1.Vid);

           
        }


    }
}
