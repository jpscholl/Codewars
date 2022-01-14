/*
//  Author: Jonathan Scholl
//  Date: 1/14/2022
//  Project: https://www.codewars.com/kata/51c8991dee245d7ddf00000e
*/
using System;

namespace Reversed_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{ReverseWords(" U YDPJO LKQWUFX UPGNMH")}");
        }
        public static string ReverseWords(string str)
        {
            string[] splitString = str.Split(' ');
            string outputString = "";

            for (int i = splitString.Length - 1; i >= 0; i--)
            {
                outputString += splitString[i] + " ";
            }
            return outputString.Substring(0, outputString.Length - 1);
        }
    }
}
