/*
//  Author: Jonathan Scholl
//  Date: 1/17/2022
//  Project: https://www.codewars.com/kata/60908bc1d5811f0025474291
*/
using System;
using System.Collections.Generic;

namespace Find_the_Squares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findSquares(9));
        }
        public static string findSquares(int n)
        {
            long a = (n + 1) / 2;
            long b = a - 1;
            return $"{a * a}-{b * b}";
        }
    }
}
