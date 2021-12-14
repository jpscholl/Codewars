/*
//  Author: Jonathan Scholl
//  Date: 12/13/2021
//  Project: Code Wars - 8 Kyu - Reversed Strings
//  Description: Complete the solution so that it reverses the string passed into it.
*/
using System;

namespace Reversed_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("World"));
        }
        public static string Solution(string str)
        {
            string newString = string.Empty;
            char[] stringToArray = str.ToCharArray();

            for (int x = stringToArray.Length - 1; x >= 0; x--)
            {
                newString += stringToArray[x];
            }
            return newString;
        }
    }
}
