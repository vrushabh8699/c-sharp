using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lazy_loading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            Console.WriteLine( c1.Name);
            for(int i = 1; i < c1. Order.Length; i++)
            {
                //Console.WriteLine($"order id : {c1.Order[i].OrderId} " +
                    //$"Descreption : {c1.Order[i].Description}");
            }
            Console.ReadLine();
        }
    }
    public class Order
    {
        public int OrderId { get; set; }

        public string Name { get; set; }    

    }
    public class Customer
    {
        public string Name { get; set;}
        
        public Order[] Order { get; set; }

        public Customer()
        {
            Name = "vishal";
            Order = GetOrders();
        }
        public Order[] GetOrders()
        {
            return new Order[]
            {
                //new Order(){OrderId = 1, Description = "Order 1"},
                //new Order(){OrderId = 2, Description = "Order 2"},
                //new Order(){OrderId = 3, Description = "Order 3"}
            };
        }
    }
}
