﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //--------program 1
            //try
            //{
            //    Console.WriteLine("enter 1 st number");
            //    int aa = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter 2 nd number");
            //    int bb = int.Parse(Console.ReadLine());

            //    divide(aa, bb);
            //    Console.ReadLine();
            //}
            //catch(FormatException ex)
            //{
            //    Console.WriteLine($"FormatException: {ex.Message}");
            //}
            //catch(OverflowException ex)
            //{
            //    Console.WriteLine($"OverflowException : {ex.Message}");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"Exception{ex.GetType().Name} : {ex}");
            //}

            //Console.WriteLine(  "thank you ");

            //Console.ReadLine();
            //-------1

            #endregion

            #region program 2
            // -------program 2
            //    Console.WriteLine("enter 1 st ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter  2 nd no");
            //int b = int.Parse(Console.ReadLine());
            //divide(a, b);

            //Console.ReadLine();
            //-------2
            #endregion program 2
            #region-----3
            //Console.WriteLine("enter X values");
            //int x=int.Parse(Console.ReadLine());

            //Console.WriteLine("enter Y values");
            //int y=int.Parse(Console.ReadLine());

            //divide(x, y);

            //Console.WriteLine("thank you visite again...||");



            //Console.ReadLine();
            #endregion-----3
            #region throw & new throw 
            //Console.WriteLine("enter your age");
            //int age = int.Parse(Console.ReadLine());
            //try
            //{
            //    if (age >= 18)
            //    {
            //        Console.WriteLine("you are eligible ,,,");
            //    }
            //    else
            //    {
            //        throw new Exception("you are not eligible");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("using catch block");
            //}


            //Console.ReadLine();
            #endregion throw & new throw 

            #region throw & new throw eg 2 

            int account = 2000;
            int withdrawl = 10000;
            try
            {
                if (account < withdrawl)
                {
                    throw new Exception ("insufficient balence");
                }
                else
                {
                    account = account - withdrawl;
                    Console.WriteLine($"remaining balence is : {account}");

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("using catch method");
            }
                
            Console.ReadLine();
            #endregion throw & new throw 





        }
        static void divide(int x, int y)
        {
            #region
            //---------1--
            //try
            //{
            //    int result = aa / bb;
            //    Console.WriteLine($"division by {aa} / {bb} = {result}");

            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("you can not divide by zero...?");
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("operation completed");

            //}

            //Console.ReadLine();
            //------1
            #endregion

            #region program 2

            //----2
            //try
            //{
            //    int result = a / b;
            //    Console.WriteLine($"division by {a} / {b} : {result}");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.GetType().Name);
            //    Console.WriteLine(ex.StackTrace);
            //    //Console.WriteLine("plz can not enter zero");
            //}

            //Console.WriteLine("division completed");
            //------2
            #endregion program 2
            #region

            //try
            //{
            //    if (y == 0)
            //    {
            //        throw new Exception("Denominator zero.......");
            //    }
            //    int result = x / y;
            //    Console.WriteLine($"Divide by {x} / {y} : {result}");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"catch block :: {ex.Message}");
            //}
            //Console.WriteLine("Operation Completed");
            #endregion-----3



        }
    }
}
