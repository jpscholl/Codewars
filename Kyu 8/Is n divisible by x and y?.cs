/*
//  Author: Jonathan Scholl
//  Date: 12/15/2021
//  Project: https://www.codewars.com/kata/5545f109004975ea66000086/train/csharp
*/
using System;

namespace Is_n_divisible_by_x_and_y
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isDivisible(3, 1, 3));
        }
        public static bool isDivisible(long n, long x, long y)
        {
            // your code
            return n % x == 0 && n % y == 0 ? true : false;
        }
    }
}
