//  Author: Jonathan Scholl
//  Date: 12/21/2021
//  Project: https://www.codewars.com/kata/5966e33c4e686b508700002d/train/csharp
*/
using System;

namespace Sum_The_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringsSum("4", ""));
        }

        public static string StringsSum(string s1, string s2)
        {
            // Write your solution here.
            if (s1 == null || s1 == string.Empty) s1 = "0";
            if (s2 == null || s2 == string.Empty) s2 = "0";

            int sumfOfString = int.Parse(s1) + int.Parse(s2);

            return sumfOfString.ToString();
        }
    }
}
