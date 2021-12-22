/*
//  Author: Jonathan Scholl
//  Date: 12/22/2021
//  Project: https://www.codewars.com/kata/56b1f01c247c01db92000076
*/
using System;

namespace Double_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(DoubleChar("Hello World!"));
        }
        public static string DoubleChar(string s)
        {
            // your code here
            string doubleCharString = string.Empty;

            for (int x = 0; x < s.Length; x++)
            {
                doubleCharString += s.Substring(x, 1);
                doubleCharString += s.Substring(x, 1);
            }
            return doubleCharString;
        }
    }
}
