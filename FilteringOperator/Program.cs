using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Operator> Sub = new List<Operator>()
            {
                new Operator() { Rollno = 12, Name = "vrud", Age = 23, City="mumbai" },
                new Operator() { Rollno = 13, Name = "vrud", Age = 13, City="pune" },
                new Operator() { Rollno = 14, Name = "vrud", Age = 18, City="mumbai" },
                new Operator() { Rollno = 15, Name = "vrud", Age = 20, City="pune" },
                new Operator() { Rollno = 16, Name = "vrud", Age = 23, City="satara" },
            };
            foreach(Operator item in Sub)
            {
                Console.WriteLine($"Rollno : {item.Rollno} Name : {item.Name} " +
                    $"Age : {item.Age} City : {item.City}");
            }
           

            Console.WriteLine("all studant city pune-----------");
            var result = Sub.Where(O => O.City.Equals("pune") && O.Age >= 10 && O.Age <=20);

            foreach(Operator item in result)
            {
                Console.WriteLine($"Rollno : {item.Rollno} Name : {item.Name} " +
                    $"Age : {item.Age} City : {item.City}");
            }



            Console.WriteLine("Oftype operator...........................");
            List<Object> Vk = new List<Object>()
                { 20, 45, "vrushbah", 10.5f, 56};

            var result1 = Vk.OfType<string>();
            foreach(var item in result1)
            {
                Console.WriteLine($"{item} ");
            };

           
            Console.ReadLine();

        }
    }
    public class Operator
    {
        public int Rollno { get; set; }

        public string Name { get; set; }    

        public int Age { get; set; }
        public string City { get; set; }    
    }
}
