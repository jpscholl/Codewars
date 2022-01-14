/*
//  Author: Jonathan Scholl
//  Date: 1/14/2022
//  Project: https://www.codewars.com/kata/57e76bc428d6fbc2d500036d
*/
using System;

namespace Convert_a_string_to_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] test = StringToArray("I love arrays they are my favorite");

            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
        }

        public static string[] StringToArray(string str)
        {
            // code code code
            return str.Split(" ");
        }
    }
}
