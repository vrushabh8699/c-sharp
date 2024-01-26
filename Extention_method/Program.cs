using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "vishal";
            string r1 = name.ToUpper();
            Console.WriteLine(r1);

            string vk = "VRUSHABH";
            string r2 = vk.ToLower();
            Console.WriteLine(r2);


            r1 = name.ToCapitalCase();
            Console.WriteLine(r1);

            r2 = vk.Trim();
            Console.WriteLine(r2);



            Console.ReadLine();

        }
    }
    public static class  StringHelper
    {
        public static string ToCapitalCase(this string name)
        {
            string result = string.Empty;
            for( int i=0; i < name.Length; i++)
            {
                if(i == 0)
                {
                    result += name[i].ToString().ToUpper();
                }
                else
                {
                    result += name[i];
                }
            }
        }
    }
}
