/*
//  Author: Jonathan Scholl
//  Date: 1/20/2022
//  Project: https://www.codewars.com/kata/55ad04714f0b468e8200001c
*/
using System;

namespace get_character_from_ASCII_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(GetChar(65));
        }
        public static char GetChar(int charcode) => Convert.ToChar(charcode);

    }
}
