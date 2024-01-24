using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Rollnumber = 111;
            s1.Name = "vrushabh";
            //s1.Gender = "male";
            //s1.Gender = 2;
            s1.Gender = Gender.Male;
            //Console.WriteLine($" Rollnumber : {s1.Rollnumber}\n Name : {s1.Name}\n Gnder : {GetGender(s1.Gender)}\n");

            Console.WriteLine($" Rollnumber : {s1.Rollnumber}\n Name : {s1.Name}\n Gnder : {s1.Gender}\n");



            Student s2 = new Student();
            s2.Rollnumber = 222;
            s2.Name = "sushant";
            // s2.Gender = "0077";
            //s2.Gender = 22;
            s2.Gender = Gender.Female;

            //Console.WriteLine($"Rollnumber : {s2.Rollnumber}\n Name : {s2.Name}\n Gender: {GetGender(s2.Gender)}");

            Console.WriteLine($"Rollnumber : {s2.Rollnumber}\n Name : {s2.Name}\n Gender: {s2.Gender}");

            Student s3 = new Student();
            s3.Rollnumber = 3;
            s3.Name = "kiran";
            s3.Gender = Gender.Unknown;
            Console.ReadLine();
        }
        static void GetGender(int Gender)
        {
            switch (Gender)
            {
                case 1:
                    Console.WriteLine("male");
                    break;
                case 2:
                    Console.WriteLine("female");
                    break;
                default :
                    Console.WriteLine("invalid");
                    break;

            }
                

        }

    }
    public class Student
    {
        public int Rollnumber { get; set; }

        public string Name { get; set; }

        //public int Gender { get; set; }  
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female=21,
        Unknown
    }
}
