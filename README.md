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
            int aa = int.Parse(Console.ReadLine());

            Console.WriteLine("enter b values");
            int bb = int.Parse(Console.ReadLine());
            Studant(aa,bb);




            Console.ReadLine();
        }
        static void Studant(int aa, int bb)
        {
            int result = aa + bb;
            Console.WriteLine($"addition: {result}");


        }
    }
    
}
