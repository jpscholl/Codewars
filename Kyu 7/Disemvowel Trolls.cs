/*
//  Author: Jonathan Scholl
//  Date: 11/16/2021
//  Project: Code Wars - Kyu 7 - Disemvowel Trolls
//  Description: 
*/
using System;

namespace Disemvowell_Trolls
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Hello World";
            Console.WriteLine(Disemvowel(test));
        }
        public static string Disemvowel(string str)
        {
            string[] vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };

            foreach (var c in vowels)
            {
                str = str.Replace(c, string.Empty);
            }

            return str;
        }
    }
}
