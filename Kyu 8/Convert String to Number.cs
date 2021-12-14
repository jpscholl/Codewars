/*
//  Author: Jonathan Scholl
//  Date: 12/13/2021
//  Project: Code Wars - 8 Kyu - Convert a String to a Number!
//  Description: We need a function that can transform a string into a number.
*/
using System;

namespace Convert_a_String_to_a_Number_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("420");
            Console.WriteLine(("420").GetType());
            Console.WriteLine(StringToNumber("420"));
            Console.WriteLine(StringToNumber("420").GetType());
        }
        public static int StringToNumber(String str)
        {
            //TODO: Convert str into a numbers
            return int.Parse(str);
        }
    }
}
