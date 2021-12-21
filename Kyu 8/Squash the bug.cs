/*
//  Author: Jonathan Scholl
//  Date: 12/21/2021
//  Project: https://www.codewars.com/kata/56f173a35b91399a05000cb7/train/csharp
*/
using System;

namespace Squash_the_bugs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindLongest("Hello World!"));
        }

        public static int FindLongest(string str)
        {
            var spl = str.Split(" ");
            var longest = 0;

            for (var i = 0; i < spl.Length; i++)
            {
                if (spl[i].Length > longest)
                {
                    longest = spl[i].Length;
                }
            }
            return longest;
        }
    }
}
