﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStyle
{
    public delegate void Del(string message);
    internal class Program
    {
        public static void DelMethod(string str)
        {
            Console.WriteLine("DelMethod argument: {0}", str);
        }
        public static void DelMethod2(string str)
        {
            Console.WriteLine("DelMethod2 argument: {0}", str);
        }
        static double ComputeDistance(double x1, double y1, double x2, double y2)
        {
            try
            {
                return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            }
            catch (System.ArithmeticException ex)
            {
                Console.WriteLine($"Arithmetic overflow or underflow: {ex}");
                throw;
            }
        }
        static void Main(string[] args)
        {
            Del exampleDel2 = DelMethod;
            exampleDel2 += DelMethod2;
            exampleDel2("Hey");

            Del exampleDel1 = new Del(DelMethod);
            exampleDel1("Hey");

            using (Font arial = new Font("Arial", 10.0f))
            {
                byte charset = arial.GdiCharSet;
            }


            Console.ReadKey();
        }
    }
}
