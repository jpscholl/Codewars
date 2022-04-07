/*
//  Author: Jonathan Scholl
//  Date: 4/7/2022
//  Project: Codewars - https://www.codewars.com/kata/563b74ddd19a3ad462000054
//  
*/
using System;

namespace Stringy_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Stringy(3));
        }
        public static string Stringy(int size)
        {
            // your code here

            string s = string.Empty;
            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    s += "1";
                }
                else
                {
                    s += "0";
                }
            }
            return s;
        }
    }
}
