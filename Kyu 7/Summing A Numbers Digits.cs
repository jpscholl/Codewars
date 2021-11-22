/*
//  Author: Jonathan Scholl
//  Date: 11/22/2021
//  Project: Code Wars - Kyu 7 - Summing a numbers digits
//  Description: Write a function named sumDigits which takes a number as input and returns the sum of the absolute value of each of the number's decimal digits.
*/
using System;

namespace Summing_a_numbers_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumDigits(-32));
        }
        public static int SumDigits(int number)
        {
            int[] splitDigits = new int[number.ToString().Length];
            int sumOfDigits = 0;

            for (int x = 0; x < splitDigits.Length; x++)
            {
                splitDigits[x] = number % 10;
                sumOfDigits += Math.Abs(splitDigits[x]);
                number = number / 10;
            }

            return sumOfDigits;
        }
    }
}
