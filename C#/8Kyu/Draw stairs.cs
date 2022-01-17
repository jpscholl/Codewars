/*
//  Author: Jonathan Scholl
//  Date: 1/17/2022
//  Project: https://www.codewars.com/kata/5b4e779c578c6a898e0005c5
*/
using System;

namespace Draw_stairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DrawStairs(4));
        }
        public static string DrawStairs(int n)
        {
            // Happy coding ;)
            var result = "I";

            for (int i = 1; i < n; i++)
            {
                var tmp = "\n";

                // Adding necessary space between each level
                for (int j = 0; j < i; j++)
                {
                    tmp += " ";
                }

                tmp += "I";
                result += tmp;
            }

            return result;
        }
    }
}
