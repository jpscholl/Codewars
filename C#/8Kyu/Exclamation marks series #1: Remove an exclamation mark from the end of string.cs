/*
//  Author: Jonathan Scholl
//  Date: 2/22/2022
//  Project: https://www.codewars.com/kata/57fae964d80daa229d000126
*/
using System;

namespace Remove_an_exclamation_mark_from_the_end_of_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Remove("Hello World!"));
        }
        public static string Remove(string s)
        {
            //coding and coding....
            if (s.EndsWith("!")) return s.Substring(0, s.Length - 1);
            return s;
        }
    }
}
