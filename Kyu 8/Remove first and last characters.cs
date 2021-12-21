/*
//  Author: Jonathan Scholl
//  Date: 12/21/2021
//  Project: https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0/train/csharp
*/
using System;

namespace Remove_First_and_Last_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Remove_char("Hello World!"));
        }
        public static string Remove_char(string s)
        {
            // Your Code
            return s.Substring(1, s.Length - 2);
        }
    }
}
