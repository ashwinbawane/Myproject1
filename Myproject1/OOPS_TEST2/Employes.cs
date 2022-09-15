using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST2
{
    class Employes
    {
        int id;
        string name;
        Dept d;

        public Employes()
        {
            Console.WriteLine("Yes");

        }

        public Employes(int id, string name, Dept d)
        {
            this.id = id;
            this.name = name;
            this.d = d;
        }

        public int ID
        {
            set { id = value; }
            get { return id; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public Dept D
        {
            set { d = value; }
            get { return d; }
        }
    }

    class Dept:Employes
    {
        int deptid;
        string dname;

        public Dept(int deptid, string dname)
        {
            this.deptid = deptid;
            this.dname = dname;
        }

        public Dept()
        {
            Console.WriteLine("Nothing");

        }

        public int Deptid
        {
            set { deptid = value; }
            get { return deptid; }
        }

        public string Dname
        {
            set { dname = value; }
            get { return dname; }
        }
    }

    class Test1
    {


        static void Main(String[] args)
        {
            
            Employes e = new Employes();
            Dept d = new Dept();

            e.ID = 101;
            e.Name = "Raghu";
            d.Deptid = 102;
            d.Dname = "Science";

            Console.WriteLine(e.ID);
            Console.WriteLine(e.Name);
            Console.WriteLine(e.D.Deptid);
            Console.WriteLine(e.D.Dname);



        }

    }



    
}
