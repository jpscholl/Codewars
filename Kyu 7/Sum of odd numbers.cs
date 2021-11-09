/*
//  Author: Jonathan Scholl
//  Date: 11/8/2021
//  Project: Code Wars - 7th Kyu - Sum of odd numbers
//  Description: Given the triangle of consecutive odd numbers:
//  Calculate the sum of the numbers in the nth row of this triangle (starting at index 1) e.g.: (Input --> Output)
//
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace Sum_Of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number: ");
            int userNum = int.Parse(Console.ReadLine());

            Console.WriteLine(rowSumOddNumbers(userNum));
        }
        public static long rowSumOddNumbers(long n) => (long)Math.Pow(n, 3);
    }
}
