/*
//  Author: Jonathan Scholl
//  Date: 1/14/2022
//  Project: https://www.codewars.com/kata/55dc4520094bbaf50e0000cb
*/
using System;

namespace Wilson_primes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AmIWilson(9));
        }
        public static bool AmIWilson(int p)
        {
            return (factorial(p - 1) + 1) / Math.Pow(p, 2) % 1 == 0;
        }
        public static int factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }
        
        //Method 2
        //basically if it 5, 13, or 563 return true...those are the only known wilson prime numbers
    }
}
