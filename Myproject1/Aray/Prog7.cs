﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject1.Aray
{
    class Prog7
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            Console.WriteLine("Enter how many elements u want to insert");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter" + size + "elements");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter new data to be added");
            int data = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter index/position where new element is to be inserted");
            int idx = int.Parse(Console.ReadLine());
            if (idx > size)
                Console.WriteLine("Invalid Position ");
            else if (idx == size)
                arr[idx] = data;
            else
            {
                int j = size - 1;
                while (j >= idx)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[idx] = data;
                size++;
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }
            





        }
    }
}

