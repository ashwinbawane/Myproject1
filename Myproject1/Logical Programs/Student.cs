using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Logical_Programs
{
    class Student
    {
        string name;
        int percentage;
        string qualification;


        public void Setname(string n)
        {
            name = n;
        }

        public void Setqualification(string q)
        {
            qualification = q;
        }

        public void Setpercentage(int p)
        {
            percentage = p;
        }


        public string Getname()
        {
            return name;
        }

        public int Getpercentage()
        {
            return percentage;
        }

        public string Getqualification()
        {
            return qualification;
        }







        static void Main(String[] args)
        {
            Logical_Programs.Student s1 = new Logical_Programs.Student();

            s1.Setname("Aashu");
            s1.Setqualification("MCA");
            s1.Setpercentage(98);

            Console.WriteLine(s1.Getname());
            Console.WriteLine(s1.Getqualification());





        }















    }
}

   

