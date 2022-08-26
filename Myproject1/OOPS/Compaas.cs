using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.OOPS
{
    
    class Pen
    {
        string brand;
        int price;
        string inkname;




        public string Brand
        {
            set { brand = value; }
            get { return brand; }
        }

        public int Price
        {
            set { price = value; }
            get { return price; }
        }


        public Pen()
        {

        }

        public Pen(string brand, int price, string inkname)
        {
            this.brand = brand;
            this.price = price;
            this.inkname = inkname;
        }

        



    }
    
    class Compaas
    {
        string compaasname;
        int price;
        Pen p;

        public string Compaasname
        {
            set { compaasname = value; }
            get { return compaasname; }
        }

        public int Price
        {
            set { price = value; }
            get { return price; }
        }

        static void Main(String[] args)
        {
            Compaas c = new Compaas();
            c.Compaasname = "Natraj";
            c.Price = 50;
            

            Pen p = new Pen("Pentek",50,"red");
            c.p = p;

            Console.WriteLine(c.p);

            


            
        }
    }
}
