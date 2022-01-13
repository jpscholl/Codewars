/*
//  Author: Jonathan Scholl
//  Date: 1/13/2022
//  Project: https://www.codewars.com/kata/5831c204a31721e2ae000294
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace Changing_letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Swap("Hello World!"));
        }
        public static string Swap(string s)
        {
            string newString = string.Empty;

            for (int x = 0; x < s.Length; x++)
            {
                if (s[x] == 'a' || s[x] == 'e' || s[x] == 'i' || s[x] == 'o' || s[x] == 'u')
                {
                    newString += s[x].ToString().ToUpper();
                }
                else
                {
                    newString += s[x].ToString();
                }   
            }

            return newString;

            /*
             * Several different ways:
             * 
             * 
             * 1) return Regex.Replace(s, "[aeiou]", m => m.Value.ToUpper());
             * 
             * 2) return string.Concat(s.Select(x => "aeiou".Contains(x) ? char.ToUpper(x) : x));
             *
             * 3) return s.Replace("a", "A").Replace("e", "E").Replace("i", "I").Replace("o", "O").Replace("u", "U");
             * 
             */
        }
    }
}
