/*
//  Author: Jonathan Scholl
//  Date: 11/1/2021
//  Project: Code Wars -- Century From Year
//  Description: The first century spans from the year 1 up to and including the year 100, 
//  the second century - from the year 101 up to and including the year 200, etc.
*/
using System;

namespace Century_From_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine(centuryFromYear(year));
        }
        public static int centuryFromYear(int year)
        {
            return (year > 1 && year < 100) ? 1 : (year % 100 == 0) ? year / 100 : year / 100 + 1;
        }
    }
}
