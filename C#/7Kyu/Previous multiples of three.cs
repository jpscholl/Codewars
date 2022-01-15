/*
//  Author: Jonathan Scholl
//  Date: 1/14/2022
//  Project: https://www.codewars.com/kata/61123a6f2446320021db987d
*/
using System;

namespace Previous_multiple_of_three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PreviousMultipleOfThree(1111));
        }
        public static int? PreviousMultipleOfThree(int n)
        {
            while (n > 0)
            {
                if (n % 3 == 0) return n;
                else n = n / 10;
            }
            return null;
        }
    }
}
