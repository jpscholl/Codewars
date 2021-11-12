/*
//  Author: Jonathan Scholl
//  Date: 11/11/2021
//  Project: Code Wars - Kyu 7 - Factorial
//  Description: Your task is to write function factorial
*/
using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
        }
        public static int factorial(int n)
        {
            int factorial = 1;

            for (int x = 1; x <= n; x++)
            {
                factorial *= x;
            }

            return factorial;
        }
    }
}
