/*
//  Author: Jonathan Scholl
//  Date: 1/13/2022
//  Project: https://www.codewars.com/kata/585b1fafe08bae9988000314
*/
using System;
using System.Linq;

namespace Digits_explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Explode("123"));
        }
        public static string Explode(string s)
        {
            string result = "";
            foreach (char i in s)
            {
                result += new String(i, int.Parse(i.ToString()));
            }
            return result;
        }
    }
}
