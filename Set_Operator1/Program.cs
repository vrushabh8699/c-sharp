using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Operator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 1, 5, 8, 9, 2, 5, 7,2 };
            var vk = num.Distinct();
            foreach(var item in vk)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // Union ============
            List<int> num1 = new List<int>() { 20, 1, 54 };

            List<int> num2 = new List<int>() { 1000, 54, 0, 85 };
            var result = num1.Concat(num2);
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            // Intersect-------------
            List<int> num3 = new List<int>() { 12, 5, 6, 8 };
            List<int> num4 = new List<int>() { 2, 5, 1, 8 };
            var re = num3.Intersect(num4);
            foreach(var item in re)
            {
                Console.Write($"{item}  ");
            }
            Console.WriteLine();
            List<int> num5 = new List<int>() { 10, 5, 8, 3, };
            List<int> num6 = new List<int>() { 1, 2, 8, 3, };
            var result11 = num5.Except(num6);
            foreach(var item in result11)
            {
                Console.Write($"{item} ");

            }




            Console.ReadLine();

        }
    }
}
