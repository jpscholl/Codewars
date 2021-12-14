/*
//  Author: Jonathan Scholl
//  Date: 12/13/2021
//  Project: Code Wars - 8 Kyu - Convert boolean values to strings 'Yes' or 'No'
//  Description: Complete the method that takes a boolean value and return a "Yes" 
//  string for true, or a "No" string for false.
*/
using System;

namespace Convert_boolean_values_to_strings_Yes_or_No
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(boolToWord(true));
            Console.WriteLine(boolToWord(false));
        }
        public static string boolToWord(bool word)
        {
            //TODO
            if (word == true) return "Yes";
            return "No";
        }
    }
}
