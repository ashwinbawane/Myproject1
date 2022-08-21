using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Logical_Programs
{
    class Trimorphic
    {
        public bool isTrimorphic(int a)
        {
            
            int c = a * a * a;

            
            while (a > 0)
            {

                
                if (a % 10 != c % 10)
                {
                    return false;
                }
                
                   

               
                a /= 10;
                c /= 10;
            }


            return true;
        }

        public static void Main()
        {
            Trimorphic t = new Trimorphic();
            Console.WriteLine("Enter any no");
            int n = int.Parse(Console.ReadLine());
            

            bool b = t.isTrimorphic(n);

            if (b == true)
                Console.Write("Trimorphic");
            else
                Console.Write("Not trimorphic");
        }






    }
}
