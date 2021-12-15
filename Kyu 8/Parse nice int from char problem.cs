/*
//  Author: Jonathan Scholl
//  Date: 12/14/2021
//  Project: https://www.codewars.com/kata/557cd6882bfa3c8a9f0000c1
*/
using System;

namespace Parse_nice_int_from_char_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetAge("3 years old"));
        }
        public static int GetAge(string inputString)
        {
            // return correct age (int). Happy coding :)
            return int.Parse(inputString.Substring(0, 1));

        }
    }
}
