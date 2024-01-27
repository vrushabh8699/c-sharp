using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generice
{
    public class Program
    {
        #region method overloading---
        //public bool AreEquel(int a, int b)
        //{
        //    return a.Equals(b);
        //}
        //public bool AreEquel(string a, string b)
        //{
        //    return a.Equals(b);
        //}
        //public bool AreEquel(float a, float b)
        //{
        //    return a.Equals(b);
        //}
        #endregion method overloading---

        
        static void Main(string[] args)
        {
            //Calculator c1 = new Calculator();

            //bool b1 = c1.AreEquel(10, 10);
            //Console.WriteLine(b1);

            // b1 = c1.AreEquel(11, 10);
            //Console.WriteLine(b1);


            //b1 = c1.AreEquel("abc","abc");
            //Console.WriteLine(b1);

            //b1 = c1.AreEquel(10.3f, 10.6f);
            //Console.WriteLine(b1);

#region generics-----
            Subject s1 = new Subject();
            bool b1=s1.AreEqual<int>(10, 20);
            Console.WriteLine(b1);

            b1 = s1.AreEqual<string>("abc", "abc");
            Console.WriteLine(b1);

            b1 = s1.AreEqual<float>(20.3f, 2.3f);
            Console.WriteLine(b1);


            Console.ReadLine();
            #endregion generics-----

        }
    }


    public class Calculator
    {
        //public bool AreEquel(object a, object b)
        //{
        //    return a.Equals(b);
        //}
        
    }
    #region generics-----

    public class Subject
    {
        public bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b); 
        }
           

    }
    #endregion generics-----


}
