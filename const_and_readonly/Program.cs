﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace const_and_readonly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Studant s1 = new Studant();
            s1.Rollnumber = 1;
            s1.Name = "vrushabh";
            //s1.CompanyName = "wipro";
            Console.WriteLine($"Rollnumber : {s1.Rollnumber} \nName : {s1.Name}\n" +
                $"Company name: {s1.CompanyName}");

            Studant s2 = new Studant();
            s2.Rollnumber = 22;
            s2.Name = "kawale";
            //s2.CompanyName = "tcs";
            Console.WriteLine($"Rollnumber : {s2.Rollnumber}\nName : {s2.Name}\n" +
                $"Company name :{s2.CompanyName}");
            
            Console.ReadLine();

        }
    }
    public class Studant
    {
        public int Rollnumber { get; set; }

        public string Name { get; set; }

        //public const string CompanyName = "v#";

        public readonly string CompanyName;
            public Studant()
            {
            CompanyName = "Cognizant";
            }
    }
}
