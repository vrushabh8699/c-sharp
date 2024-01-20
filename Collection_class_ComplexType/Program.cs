using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_class_ComplexType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region list 
            Studant s1 = new Studant() { ROllNo = 1, Name = "vrushabh", City = "yavatmal"};
            Studant s2 = new Studant() { ROllNo = 2, Name = "sushant", City = "pune"};
            Studant s3 = new Studant() { ROllNo = 11, Name = "rishnoi", City = "mumbai"};
            Studant s4 = new Studant() { ROllNo = 12, Name = "arti", City = "satara"};
            List<Studant> college = new List<Studant>();
            college.Add(s1);
            college.Add(s2);
            college.Add(s3);
            college.Add(s4);

            Console.WriteLine($"All Studant ********");
            foreach (Studant item in college)
            {
                Console.WriteLine($"roll no : {item.ROllNo} Name : {item.Name} City : {item.City}");
            }
            #endregion list 

            Dictionary<int, Studant> Topper=new Dictionary<int, Studant>();
            Topper.Add(s1.ROllNo, s1);
            Topper.Add(s2.ROllNo, s2);
            Topper.Add(s3.ROllNo, s3);
            Topper.Add(s4.ROllNo, s4);
            //Studant s = Topper[2];
            Console.WriteLine("All Studant");
            foreach(var item in Topper)
            {
                Console.WriteLine(item.Key);
                Studant ss = item.Value;

                Console.WriteLine($"RollNo : {ss.ROllNo}" +
                    $" Name : {ss.Name} City : {ss.City}");
            }
            Console.ReadLine();

        }
    }
    public class Studant
    {
        public int ROllNo { get; set; }
        public  string Name { get; set; }
        public  string City { get; set; }
    }
}   
