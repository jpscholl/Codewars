/*
//  Author: Jonathan Scholl
//  Date: 11/9/2021
//  Project: Code Wars - Kyu 7 - Shortest Word
//  Description: Simple, given a string of words, return the length of the shortest word(s).
*/
using System;
using System.Linq;

namespace Shortest_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindShort("He Wor"));
        }
        public static int FindShort(string s)
        {
            string[] splitString = s.Split(" ");
            string shortString = splitString[0];

            for (int x = 1; x < splitString.Length; x++)
            {
                if (shortString.Length > splitString[x].Length) shortString = splitString[x];
            }

            return shortString.Length;

            //System.Linq version
            //return s.Split(' ').Min(x => x.Length);
        }
    }
}
