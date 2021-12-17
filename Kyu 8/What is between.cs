/*
//  Author: Jonathan Scholl
//  Date: 12/17/2021
//  Project: https://www.codewars.com/kata/55ecd718f46fba02e5000029
*/
using System;

namespace What_is_between
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            foreach (var item in Between(1, 4))
            {
                Console.Write($"{item} ");
            }
        }

        public static int[] Between(int a, int b)
        {
            // your code here
            int[] rangeArray = new int[b - a + 1];
            
            for (int x = 0; a <= b; x++, a++)
            {
                rangeArray[x] = a;
            }

            return rangeArray;
        }
    }
}
