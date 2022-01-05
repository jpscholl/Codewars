/*
//  Author: Jonathan Scholl
//  Date: 1/4/2022
//  Project: https://www.codewars.com/kata/57a0556c7cb1f31ab3000ad7
*/
using System;

namespace MakeUpperCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(MakeUpperCase("Hello World!"));
        }
        public static string MakeUpperCase(string str)
        {
            return str.ToUpper();
        }
    }
}
