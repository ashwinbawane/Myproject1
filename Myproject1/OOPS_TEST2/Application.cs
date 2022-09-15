using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS_TEST2
{
    class Application
    {
        string version;
        string technology_used;
        Developer d;

        public Application(string version, string technology_used, Developer d)
        {
            this.version = version;
            this.technology_used = technology_used;
            this.d = d;

        }

        public Application()
        {

        }

        public string Version
        {
            set { version = value; }
            get { return version; }
        }

        public string Technology_used
        {
            set { technology_used = value; }
            get { return technology_used; }
        }

        public Developer D
        {
            set { d = value; }
            get { return d; }
        }

        public void install()
        {

        }

        public void unistall()
        {

        }
    }

    class Developer
    {
        string devname;
        string dev_skills;
        int  experiance;

        public Developer()
        {

        }

        public Developer(string devname, string dev_skills, int experiance)
        {
            this.devname = devname;
            this.dev_skills = dev_skills;
            this.experiance = experiance;
        }

        public string Devname
        {
            set { devname = value; }
            get { return devname; }
        }

        public string Dev_skills
        {
            set { dev_skills = value; }
            get { return dev_skills; }
        }

        public int Experiance
        {
            set { experiance = value; }
            get { return experiance; }
        }

        public void debug_App()
        {

        }

        public void integrated_code()
        {

        }



    }

    class Test2
    {
        static void Main(String[] args)
        {
            
        }
    }
}
