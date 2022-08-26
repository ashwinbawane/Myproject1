using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS
{
    class Employee
    {
        int employee_id;
        string name;
        int salary;

        public int Employee_Id
        {
            set { employee_id = value; }
            get { return employee_id; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Salary
        {
            set { salary = value; }
            get { return salary; }
        }

        static void Main(String[] args)
        {
            Employee e = new Employee();

            e.Employee_Id = 1101;
            e.Name = "Santosh";
            e.Salary = 30000;

            Console.WriteLine(e.Employee_Id);
            Console.WriteLine(e.Name);
            Console.WriteLine(e.Salary);

        }
    }
}
