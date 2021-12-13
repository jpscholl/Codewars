/*
//  Author: Jonathan Scholl
//  Date: 12/13/2021
//  Project: Code Wars - 8 Kyu - Convert a String to Boolean
//  Description: Implement a function which convert the given 
//  boolean value into its string representation.
*/
using System;

namespace Convert_a_Boolean_to_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(boolean_to_string(true));
            Console.WriteLine(boolean_to_string(false));
        }
        public static string boolean_to_string(bool b)
        {
            //Please don't delete me!

            return b.ToString();
        }
    }
}
