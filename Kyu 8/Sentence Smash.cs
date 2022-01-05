/*
//  Author: Jonathan Scholl
//  Date: 1/4/2022
//  Project: https://www.codewars.com/kata/53dc23c68a0c93699800041d
*/
using System;

namespace Sentence_Smash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Smash(new string[] {"this", "is", "a", "really", "long", "sentence"}));
        }

        public static string Smash(string[] words)
        {
            // Smash words
            string outputString = string.Join(" ", words);

            return outputString.TrimEnd();
        }
    }
}
