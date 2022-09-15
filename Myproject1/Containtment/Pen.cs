using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Containtment
{
    class Pen
    {
        Reffil r;
        int caplength;
        string brand;


        public Pen()
        {

        }

        public Pen(Reffil r, int caplength, string brand)
        {
            this.r = r;
            this.caplength = caplength;
            this.brand = brand;
        }

        public int Caplength
        {
            set { caplength = value; }
            get { return caplength; }

        }

        public string Brand
        {
            set { brand = value; }
            get { return brand; }
        }

        public Reffil R
        {
            set { r = value; }
            get { return r; }
        }

        

    }


        class Reffil
        {
             int length;
            string inkcolor;
            
            Nib n;


            public string Inkcolor
            {
                set { inkcolor = value; }
                get { return inkcolor; }
            }

            public int Length
            {
                set { length = value; }
                get { return length; }
            }

        }

        class Nib
        {
            string material_type;
                int width;

            public string Material_type
            {
                set { material_type = value; }
                get { return material_type; }
            }

            public int Width
            {
                set { width = value; }
                get { return width; }
            }

            public Nib()
        {

        }

         public Nib(string material_type, int width)
        {
            this.material_type = material_type;
            this.width = width;
        }





        }

    class Bank
    {


        static void Main(String[] args)
        {
            Pen p = new Pen();
            Reffil r = new Reffil();
            Nib n = new Nib();

            p.Caplength = 5;
            p.Brand = "Pentek";
            
            Console.WriteLine(p.Caplength);
            Console.WriteLine(p.Brand);

            r.Inkcolor = "Red";
            r.Length = 10;

            Console.WriteLine(p.R.Inkcolor);
            Console.WriteLine(p.R.Length);

            n.Material_type = "Plastic";
            n.Width = 8;

            Console.WriteLine(n.Material_type);
            Console.WriteLine(n.Width);


        }

    }
}
