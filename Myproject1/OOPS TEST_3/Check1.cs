using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST_3
{
    class Flat
    {
        int flatno;
        string Wing_name;
        Member member;
        internal object m;

        public int Flatno
        {
            set { value = flatno; }
            get { return flatno; }
            

        }

        public string Wing_Name
        {
            set { value = Wing_Name; }
            get { return Wing_Name; }
        }

        public Member Member
        {
            set { value = member; }
            get { return member; }
        }

        public Flat()
        {

        }

        public Flat(int flatno, string Wing_name, Member member)
        {
            this.flatno = flatno;
            this.Wing_name = Wing_name;
            this.member = member;

        }



    }

    class Member
    {
        int memberid;
        string mem_name;
        string proffession;
        int age;

        public Member()
        {
                
        }

        public Member(int memberid, string mem_name, string proffession, int age)
        {
            this.memberid = memberid;
            this.mem_name = mem_name;
            this.proffession = proffession;
            this.age = age;
                
        }

        public int Memberid
        {
            set { value = memberid; }
            get { return memberid; }
        }

        public string Mem_name
        {
            set { value = mem_name; }
            get { return mem_name; }
        }

        public string Proffession
        {
            set { value = proffession; }
            get { return proffession; }
        }

        public int Age
        {
            set { value = age; }
            get { return age; }
        }


    }

    class Check1
    {
        static void Main(String[] args)
        {
            Flat f = new Flat();
            Member m = new Member();


            f.Flatno = 101;
            f.Wing_Name = "Charlie";
            m.Memberid = 1101;
            m.Mem_name = "Ashwin";
            m.Proffession = "job";
            m.Age = 22;

            
            

        }
    }
}
