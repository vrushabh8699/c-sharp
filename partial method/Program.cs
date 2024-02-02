using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial_method
{
    public class Program
    {
        static void Main(string[] args)
        {
            student s = new student()
            { Name = "vishal" };
            s.AddEnquiry();
            Console.ReadLine();
        }
    }
}
