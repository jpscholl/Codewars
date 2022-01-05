/*
//  Author: Jonathan Scholl
//  Date: 1/4/2022
//  Project: https://www.codewars.com/kata/55cbc3586671f6aa070000fb
*/
using System;

namespace Grasshopper___Check_for_factor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckForFactor(7, 2));
        }
        public static bool CheckForFactor(int num, int factor)
        {
            // code here
            return num % factor == 0;
        }
    }
}
