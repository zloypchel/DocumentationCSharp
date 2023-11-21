﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StandartBlock
{
    public class Color
    {
        public static readonly Color Black = new Color(0, 0, 0);
        public static readonly Color White = new Color(255, 255, 255);
        public static readonly Color Red = new Color(255, 0, 0);
        public static readonly Color Green = new Color(0, 255, 0);
        public static readonly Color Blue = new Color(0, 0, 255);
        public byte R;
        public byte G;
        public byte B;
        public Color(byte r, byte g, byte b)
        {
            R = r; G = g; B = b;
        }
        public override string ToString() => "This is an object";

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void SwapExample()
        {
            int i = 1, j = 2;
            Swap(ref i, ref j);
            Console.WriteLine($"{i} {j}");
        }

        static void Divide(int x, int y, out int quotient, out int remainder)
        {
            quotient = x / y;
            remainder = x % y;
        }
        public static void OutUsage()
        {
            Divide(10, 3, out int quo, out int rem);
            Console.WriteLine($"{quo} {rem}");
        }

        public static void WriteLine(params int[] i)
        {
            foreach(int x in i)
            {
                Console.WriteLine(x);
            }
        }
    }
}
