/*
//  Author: Jonathan Scholl
//  Date: 12/13/2021
//  Project: Code Wars - 8 Kyu - Vowel remover
//  Description: Create a function called shortcut to remove all the lowercase vowels in a given string.
*/
using System;
using System.Linq;

namespace Vowel_remover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Shortcut("Hello World!"));
        }
        public static string Shortcut(string input)
        {
            // TODO: Remove vowels
            char[] vowels = {'a', 'e', 'i', 'o', 'u' };

            string removeVowels = new string(input.Where(c => !vowels.Contains(c)).ToArray());

            return removeVowels;
        }
    }
}
