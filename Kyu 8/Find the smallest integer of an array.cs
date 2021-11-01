/*
//  Author: Jonathan Scholl
//  Date: 11/1/2021
//  Project: Find the smallest integer in the array
//  Description: Given an array of integers your solution should find the smallest integer.

*/
using System;
using System.Linq;

namespace Smallest_Integer_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] { 78, 56, 232, 12, 11, 43 };

            Console.WriteLine($"Smallest int: {FindSmallestInt(numArray)}");

        }
        public static int FindSmallestInt(int[] args) => args.Min();
    }
}
