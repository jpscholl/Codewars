/*
//  Author: Jonathan Scholl
//  Date: 11/9/2021
//  Project: Beginner Series #3 Sum of Numbers
//  Description: Given two integers a and b, which can be positive or negative, find the sum of all the integers 
//  between and including them and return it. If the two numbers are equal return a or b.
*/
using System;
using System.Linq;

namespace Sum_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt and store input
            Console.WriteLine("Input integer a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input integer b: ");
            int b = int.Parse(Console.ReadLine());

            //output results
            Console.WriteLine($"Sum of range ({a} - {b}) = {GetSum(a,b)}");

        }
        //one line method checks if a and b are equal then outputs reults based on that
        public static int GetSum(int a, int b)
        {
            int sumOfRange = 0;
            int higherNum = a > b ? a : b;
            int lowerNum = a < b ? a : b;

            for (int x = lowerNum; x <= higherNum; x++)
            {
                sumOfRange += x;
            }

            return sumOfRange;
        }
    }
}
