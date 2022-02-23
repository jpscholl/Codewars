/*
//  Author: Jonathan Scholl
//  Date: 11/22/2021
//  Project: Code Wars - Kyu 6th - Convert string to camel case
//  Description: Complete the method/function so that it converts dash/underscore delimited words into camel casing.  
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace Convert_string_to_camel_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToCamelCase("the-stealth-warrior"));
        }
        public static string ToCamelCase(string str)
        {

            string temp = string.Empty;

            for (int x = 0; x < str.Length; x++)
            {
                if (str[x] == '_' || str[x] == '-')
                {
                    temp += Char.ToUpper(str[x + 1]);
                    x++;
                }
                else
                {
                    temp += str[x];
                }
                
            }

            return temp.Replace("-", "").Replace("_", "");
        }   
    }
}
