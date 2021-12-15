/*
//  Author: Jonathan Scholl
//  Date: 12/14/2021
//  Project: https://www.codewars.com/kata/5a2b703dc5e2845c0900005a
*/
using System;

namespace Can_we_divide_it
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(is_divide_by(-12, 2, -5));
        }
        public static bool is_divide_by(int number, int a, int b)
        {
            // good luck
            return number % a == 0 && number % b == 0;
        }
    }
}
