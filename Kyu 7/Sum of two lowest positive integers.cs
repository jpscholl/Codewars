/*
//  Author: Jonathan Scholl
//  Date: 11/9/2021
//  Project: Code Wars - Kyu 7 - Sum of two lowest positive integers
//  Description: Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers. No floats or non-positive integers will be passed.
*/
using System;
using System.Linq;

namespace Sum_of_two_lowest_positive_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //test variable
            int[] testArray = new int[] {5, 8, 12, 19, 22};

            //output results
            Console.WriteLine($"Sum of smallest integers: {sumTwoSmallestNumbers(testArray)}");
        }
        //my answer
        //add together two smallest ints inside array
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            //Code here...
            Array.Sort(numbers);
            return numbers.Length >= 4 ? numbers[0] + numbers[1] : 0;
        }

        //one line answer
        //return numbers.OrderBy(i => i).Take(2).Sum();
    }
}
