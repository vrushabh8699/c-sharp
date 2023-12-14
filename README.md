# c-sharp Addition program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_and_as
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("enter a values");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter b values");
            int b = int.Parse(Console.ReadLine());
            Studant(a,b);




            Console.ReadLine();
        }
        static void Studant(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"addition: {result}");


        }
    }
    
}
