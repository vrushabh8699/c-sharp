﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vrus = new int[5];
            vrus[0] = 500;
            vrus[1] = 2000;
            vrus[2] = 100;
            vrus[3] = 1100;
            vrus[4] = 100;
            for (int i = 0; i < vrus.Length; i++)
            {
                Console.WriteLine($"{vrus[i]} ");
            }

            string[] name = new string[] { "vru", "shu", "vihan", "vrush" };
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write($"{name[i]} ");
            }

            #region reverse array
            int[] num = new int[] { 1, 2, 3, };
            Console.WriteLine("original number");
            for (int i = 0; i < num.Length; i++) 
            {
                Console.Write($"{num[i]} ");  
            }
            Console.WriteLine("\nreverse number");
            for (int i = num.Length-1; i >=0 ; i--)
            {
                Console.Write($"{num[i]} ");
            }
            #endregion reverse array



            Console.ReadLine();
        }
    }
}

