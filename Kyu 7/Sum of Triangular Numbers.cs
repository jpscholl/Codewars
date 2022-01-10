/*
//  Author: Jonathan Scholl
//  Date: 1/10/2022
//  Project: https://www.codewars.com/kata/580878d5d27b84b64c000b51
*/
using System;

namespace Sum_Of_Triangular_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(SumTriangularNumbers(3));
        }
        public static int SumTriangularNumbers(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i * (i + 1) / 2;
            }
            return sum;
        }
    }
}
