using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Containtment
{
    class Order
    {
        int order_id;
        int orderdate;
        Customer cust;


        public Order()
        {

        }

        public Order(int order_id, int orderdate, Customer cust)
        {
            this.order_id = order_id;
            this.orderdate = orderdate;
            this.cust = cust;


        }

        public int Order_id
        {
            set { order_id = value; }
            get { return order_id; }
        }

        public int Orderdate
        {
            set { orderdate = value; }
            get { return orderdate; }
        }

        public Customer Cust
        {
            set { cust = value; }
            get { return cust; }
        }

    }


    class Customer
    {
        int cust_id;
        string cust_name;
        Address a;

        public int Cust_id
        {
            set { cust_id = value; }
            get { return cust_id; }
        }

        public string Cust_name
        {
            set { cust_name = value; }
            get { return cust_name; }
        }

        public Customer()
        {

        }

        public Customer(int cust_id, string cust_name)
        {
            this.cust_id = cust_id;
            this.cust_name = cust_name;
        }
    }

    class Address
    {
        string city;
        int pincode;
        Item item;



        public string City
        {
            set { city = value; }
            get { return city; }
        }

        public int Pincode
        {
            set { pincode = value; }
            get { return pincode; }
        }

        public Address()
        {

        }

        public Address(string city, int pincode)
        {
            this.city = city;
            this.pincode = pincode;
        }
    }
                class Item
                {
                    int item_id;
                    string item_name;
                    int price;


                    public int Item_id
                    {
                        set { item_id = value; }
                        get { return item_id; }
                    }

                    public string Item_name
                    {
                        set { item_name = value; }
                        get { return item_name; }
                    }

                    public Item()
                    {

                    }

                    public Item(int item_id, string item_name, int price)
                    {
                        this.item_id = item_id;
                        this.item_name = item_name;
                        this.price = price;
                    }
                
        static void Main(String[] args)
        {
            Order o = new Order();
            o.Order_id = 101;
            o.Orderdate = 10 - 1 - 2022;
            o.Cust = new Customer();
            o.Cust.Cust_id = 101;
            o.Cust.Cust_name = "Rahul";
            

        }
    }
}
