/*
//  Author: Jonathan Scholl
//  Date: 12/22/2021
//  Project: https://www.codewars.com/kata/55a70521798b14d4750000a4
*/
using System;

namespace Returning_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Greet("Jon"));
        }
        public static string Greet(string name)
        {
            return $"Hello, {name} how are you doing today?";
        }
    }
}
