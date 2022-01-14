/*
//  Author: Jonathan Scholl
//  Date: 1/14/2022
//  Project: https://www.codewars.com/kata/57eae65a4321032ce000002d
*/
using System;

namespace Fake_Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FakeBin("45385593107843568"));
        }
        public static string FakeBin(string x)
        {
            string fakeBinary = string.Empty;

            for (int i = 0; i < x.Length; i++)
                if (Char.GetNumericValue(x[i]) > 4) fakeBinary += "1";
                    else fakeBinary += "0";

            return fakeBinary;
        }
    }
}
