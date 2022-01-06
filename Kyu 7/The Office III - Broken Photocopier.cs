/*
//  Author: Jonathan Scholl
//  Date: 1/5/2022
//  Project: https://www.codewars.com/kata/57ed56657b45ef922300002b
*/
using System;

namespace The_Office_III___Broken_Photocopier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("101");
            Console.WriteLine(Broken("101"));
        }
        public static string Broken(string x)
        {
            string newString = string.Empty;
            char[] splitString = x.ToCharArray();

            for (int i = 0; i < splitString.Length; i++)
            {
                if (splitString[i] == '0') newString += '1';
                else newString += '0';

            }
            return newString;
        }
    }
}
