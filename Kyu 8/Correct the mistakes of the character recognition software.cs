/*
//  Author: Jonathan Scholl
//  Date: 12/14/2021
//  Project: https://www.codewars.com/kata/577bd026df78c19bca0002c0
//  Description: Your task is correct the errors in the digitised text.
*/
using System;
using System.Linq;

namespace Correct_mistake_character_recognition_software
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Correct("501L"));
        }
        public static string Correct(string text)
        {
            if (text.Contains("5")) text = text.Replace("5", "S");
            if (text.Contains("0")) text = text.Replace("0", "O");
            if (text.Contains("1")) text = text.Replace("1", "I");

            return text;
        }
    }
}
