using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Method_Overloading
{
    class Frequency
    {
        public void Number(int num, int d)
        {
            int c = 0;
             
            while(num > 0)
            {
                if(num % 10 == 0)
                {
                    c++;
                    num = num / 10;

                    Console.WriteLine(c);
                    
                }
                
                

            }

        }

        public void Number(int n1)
        {
            int sum = 0;
            
            for(int i = 2; i <= n1; i = i + 2)
            {
                sum = sum + i;
                Console.WriteLine(sum);
            }

        }


        static void Main(String[] args)
        {
            Console.WriteLine("Enter any digit");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter any no");
            int b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter any no");
            //int d = int.Parse(Console.ReadLine());

            Frequency f = new Frequency();

            f.Number(a, b);
            //f.Number(d);

            
            


        }
    }
}
