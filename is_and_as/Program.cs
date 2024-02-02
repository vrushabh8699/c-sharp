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


            //Console.WriteLine("enter a values");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter b values");
            //int b = int.Parse(Console.ReadLine());
            //Studant(a,b);


            ************************************

            object s = "abc";

            if (s is string)
            {
                Console.WriteLine("this is of same type");
            }
            else
            {
                Console.WriteLine("not same");
            }
            object s = 123;
            string x = s as string;

            Console.ReadLine();


        }
        
        static void Studant(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"addition: {result}");


        }
    }
    
}
