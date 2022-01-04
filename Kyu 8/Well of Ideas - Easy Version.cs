/*
//  Author: Jonathan Scholl
//  Date: 1/4/2022
//  Project: https://www.codewars.com/kata/57f222ce69e09c3630000212
*/
using System;

namespace Well_of_Ideas___Easy_Version
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Well(new string[] {"good", "good", "good"}));
        }

        public static string Well(string[] x)
        {
            int goodCount = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == "good") goodCount++;
            }

            if (goodCount > 2) return "I smell a series!";
            if (goodCount > 0) return "Publish!";
            return "Fail!";
        }
    }
}
