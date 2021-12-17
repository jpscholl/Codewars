/*
//  Author: Jonathan Scholl
//  Date: 12/17/2021
//  Project: https://www.codewars.com/kata/56dec885c54a926dcd001095
*/
using System;

namespace Opposite_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Opposite(2));
        }
        public static int Opposite(int number)
        {
            // Happy Coding
            if (number > 0) return number * -1;

            return Math.Abs(number);
        }
    }
}
