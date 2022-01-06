/*
//  Author: Jonathan Scholl
//  Date: 1/6/2022
//  Project: https://www.codewars.com/kata/57a62154cf1fa5b25200031e
*/
using System;

namespace Alternate_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(alternateCase("Hello World!"));
        }
        public static string alternateCase(string s)
        {
            char[] splitString = s.ToCharArray();
            string newString = string.Empty;

            for (int i = 0; i < splitString.Length; i++)
            {
                if (char.IsUpper(splitString[i])) //if upper case
                {
                    //make letter lower
                    //add to new string
                    newString += splitString[i].ToString().ToLower();
                }
                else //if lower case
                {
                    //make letter upper
                    //add to new string
                    newString += splitString[i].ToString().ToUpper();
                }
            }

            return newString;
        }
    }
}
