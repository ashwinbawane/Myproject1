using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS
{
    class Account 
    {
        string accountname;
        int depositamount;
        int withdrawamount;


        public string Accountname
        {
            set { accountname = value; }
            get { return accountname; }

        }

        public int Depositamount
        {
            set { depositamount = value; }
            get { return depositamount; }
        }

        public int Withdrawamount
        {
            set { withdrawamount = value; }
            get { return withdrawamount; }

        }

        static void Main(String[] args)
        {
            Account a = new Account();

            a.Accountname = "Ashwin";
            a.Depositamount = 100000;
            a.Withdrawamount = 50000;

            Console.WriteLine("Account Name is " + a.Accountname);
            Console.WriteLine("Deposit Amount is " + a.Depositamount);
            Console.WriteLine("Withdraw amount is " + a.Withdrawamount);





        }



    }
}
