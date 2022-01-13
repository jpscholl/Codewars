/*
//  Author: Jonathan Scholl
//  Date: 12/14/2021
//  Project: Code Wars = 8 Kyu - ASCII Total
//  Description: Sum the ASCII digits of a string
*/
using System;

namespace ASCII_Total
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UniTotal("aa"));

        }
        public static int UniTotal(string str)
        {
            // total up dem unicodes!
            int sumOfChar = 0;
            char[] stringToCharArray = str.ToCharArray();

            foreach (var item in stringToCharArray)
            {
                sumOfChar += (int)item;
            }

            return sumOfChar;
        }
    }
}
