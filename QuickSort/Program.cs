﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        //array of interger to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; // number of comprasion
        private int mov_count = 0; // number of data movements

        // Nimber od elements in array 
        private int n;

        void read()
        {
            while(true)
            {
                Console.Write("Enter The number of elemnts in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\n Array can have maximum 30 elements \n ");
            }
            Console.WriteLine("\n=====================");
            Console.WriteLine(" Enter Array Elements");
            Console.WriteLine("\n=====================");




        }
            
           


           }
}
