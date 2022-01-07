/*
//  Author: Jonathan Scholl
//  Date: 1/7/2022
//  Project: https://www.codewars.com/kata/6129095b201d6b000e5a33f0
*/
using System;

namespace Boxlines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(F(1, 1, 1));
        }

        public static ulong F(ushort x, ushort y, ushort z)
        {
            var X = x * (1UL + y) * (1UL + z);
            var Y = y * (1UL + x) * (1UL + z);
            var Z = z * (1UL + y) * (1UL + x);
            return X + Z + Y;
        }
    }
}
