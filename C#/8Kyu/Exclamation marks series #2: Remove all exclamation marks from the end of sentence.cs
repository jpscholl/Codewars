/*
//  Author: Jonathan Scholl
//  Date: 1/13/2022
//  Project: https://www.codewars.com/kata/57faece99610ced690000165
*/
using System;

namespace Exclamation_marks_series_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Remove("Hello! World!!!!"));
        }
        public static string Remove(string s)
        {
            //coding and coding...
            while(s.EndsWith('!'))
            {
                s = s.Substring(0, s.Length - 1);
            }
            return s;
        }
    }
}
