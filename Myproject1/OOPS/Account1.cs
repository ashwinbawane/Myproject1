using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS
{
    class Account1
    {
        int accountno;
        string accountname;

        public void setAccountNo(int n)
        {
            accountno = n;
        }

        public void setName(string a)
        {
            accountname = a;
        }

        public int getAccountno()
        {
            return accountno;
        }

        public string getName()
        {
            return accountname;
        }

        static void Main(String[] args)
        {
            Account1 a = new Account1();
            a.setAccountNo(1234755);
            a.setName("Aashu");

            Console.WriteLine(a.getAccountno());
            Console.WriteLine(a.getName());





        }
    }
}
