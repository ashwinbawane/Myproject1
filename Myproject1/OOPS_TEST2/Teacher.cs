/*using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST2
{
     class Teacher
     {
        int Tid;
        string Tname;
        int Mobileno;
        Hourlybased h;

        public Teacher()
        {

        }

        public Teacher(int Tid, string Tname, int Mobileno, Hourlybased h)
        {
            this.Tid = Tid;
            this.Tname = Tname;
            this.Mobileno = Mobileno;
            this.h = h;

        }

        public int TID
        {
            set { Tid = value; }
            get { return Tid;}
        }

        public string TName
        {
            set { Tname = value; }
            get { return Tname; }
        }

        public int MobileNo
        {
            set { Mobileno = value; }
            get { return Mobileno; }
        }

        public Hourlybased H
        {
            set { h = value; }
            get { return h; }
        }
       


        abstract void salary()
        {

        }
    }

    class Hourlybased:Teacher
    {
        int rate_pr_hr;
        int hrs;
        Salarybased s;

        public int Rate_Pr_Hr
        {
            set { rate_pr_hr = value; }
            get { return rate_pr_hr; }
        }

        public int Hrs
        {
            set { hrs = value; }
        }

        public Salarybased S
        {
            set { s = value; }
            get { return s; }
        }


        public Hourlybased()
        {

        }

        public Hourlybased(int rate_pr_hr, int hrs, Salarybased s)
        {
            this.rate_pr_hr = rate_pr_hr;
            this.hrs = hrs;
            this.s = s;
        }

         void salary()
        {

        }
    }



    class Salarybased:Teacher

    {
        int salary;


        public int Salary
        {
            set { salary = value; }
            get { return salary; }
        }
        public Salarybased(int salary)
        {
            this.salary = salary;
        }

        public Salarybased():base()
        {

        }

        public void salary()
        {

        }
    }



    class Test
    {

        static void Main(String[] args)
        {
            Teacher t = new Teacher();
            Salarybased s = new Salarybased();
           
            
            



        }
    }

        
        
    
}*/
