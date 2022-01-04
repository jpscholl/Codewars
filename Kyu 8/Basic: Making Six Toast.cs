/*
//  Author: Jonathan Scholl
//  Date: 1/4/2022
//  Project: https://www.codewars.com/kata/5834fec22fb0ba7d080000e8/train/csharp
*/
using System;

namespace BASIC_Making_Six_Toast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SixToast(5));
            Console.WriteLine(SixToast(6));
            Console.WriteLine(SixToast(17));
        }
        public static int SixToast(int num)
        {
            // TODO: Write this function to the provided spec
            if (num <= 6) return 6 - num;
            return num - 6;
        }
    }
}
