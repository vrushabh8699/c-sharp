using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Arraylist
           
            //Console.BackgroundColor = ConsoleColor.DarkRed;
            //ArrayList number = new ArrayList();
            //number.Add(10);
            //number.Add(20);
            //number.Add(30);
            //number.Add(40);
            //number.Add(50);

            //number.Insert(1, 17);
            //number.Remove(40);
            //number.RemoveRange(0, 3);
            //number.Clear();
            //Console.WriteLine($"no of item : {number.Count}");
            ////1 t ways using for loop
            //for (int i = 0; i < number.Count; i++)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            ////2nd ways using forech loop

            //foreach (int item in number)
            //{
            //    Console.WriteLine($"series : {item}");
            //}
            #endregion Arraylist

            #region stack method 

            Stack visit = new Stack();
            visit.Push("google.com");
            visit.Push("facebook.com");
            visit.Push("facebook.com/friends");
            visit.Push("facebook.com/friends/vrushabh");

            Console.WriteLine($"number of item: {visit.Count}");
            var site=visit.Pop();
            Console.WriteLine($"returns : {site}");

            site = visit.Peek();
            Console.WriteLine($"return : {site}");

            #endregion stack method 

            #region queue
            
            Queue bank = new Queue();
            bank.Enqueue("vrushabh");
            bank.Enqueue("sushant");
            bank.Enqueue("roshni");
            bank.Enqueue("arti");

            Console.WriteLine($"number of list : {bank.Count}");

            var token = bank.Dequeue();
            Console.WriteLine($" Dequeue : {token}");
            Console.WriteLine($"number of list : {bank.Count}");
            
            token = bank.Peek();
            Console.WriteLine($" peek : {token}");
            Console.WriteLine($" number of list : {bank.Count}");


            #endregion queue 


            Console.ReadLine();

        }
    }
}
