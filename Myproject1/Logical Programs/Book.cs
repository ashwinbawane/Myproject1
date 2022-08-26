using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Logical_Programs
{
    class Book
    {
        string bookname;
        int price;
        string authorname;

        public string Bookname
        {
            set { bookname = value; }
            get { return bookname; }
        }

        public int Price
        {
            set { price = value; }
            get { return price; }
        }

        public string Authorname
        {
            set { authorname = value; }
            get { return authorname; }

        }


        static void Main(String[] args)
        {
            Book b = new Book();

            b.Bookname = "Halfgirlfriend";
            Console.WriteLine(b.Bookname);

            b.Price = (258);
            Console.WriteLine(b.Price);

            b.Authorname = "Chetan Bhagat";
            Console.WriteLine(b.Authorname);


        }
            
    }
}
