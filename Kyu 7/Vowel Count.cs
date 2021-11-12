/*
//  Author: Jonathan Scholl
//  Date: 11/11/2021
//  Project: Code War - Kyu 7 - Vowel Count
//  Description: Return the number (count) of vowels in the given string.
*/
using System;
using System.Linq;

namespace Vowel_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetVowelCount("Hello World!"));

        }
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            // Your code here

            for (int x = 0; x < str.Length; x++)
                if (str[x] == 'a' || str[x] == 'e' || str[x] == 'i' || str[x] == 'o' || str[x] == 'u')
                {
                    vowelCount++;
                }

            return vowelCount;
        }
    }
}
