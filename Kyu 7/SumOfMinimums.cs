/*
//  Author: Jonathan Scholl
//  Date: 11/11/2021
//  Project: Code Wars - 7th Kyu - Sum Of Minimums 
//  Description: C# https://www.codewars.com/kata/5d5ee4c35162d9001af7d699/train/csharp
*/
using System;

namespace SumOfMinimums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] testArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 5, 6, 7, 8, 9 }, { 20, 21, 34, 56, 100 } };
            Console.WriteLine("Hello World!");

            Console.WriteLine($"\nSum of min: {SumOfMinimums(testArray)}");
        }
        public static int SumOfMinimums(int[,] numbers)
        {
            // your code here
            int minSum = 0;
            int x, y, temp;
            
            for (x = 0; x < numbers.GetLength(0); x++)
            {
                y = 0;
                temp = numbers[x, y];
                for (y = 0; y < numbers.GetLength(1); y++)
                {
                    if (temp > numbers[x, y]) temp = numbers[x, y];
                    Console.WriteLine(numbers[x, y]);
                }
                minSum += temp;
                Console.WriteLine();
            }

            return minSum;
        }
    }
}
