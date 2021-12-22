/*
//  Author: Jonathan Scholl
//  Date: 12/22/2021
//  Project: https://www.codewars.com/kata/5748838ce2fab90b86001b1a
*/
using System;

namespace Area_of_square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquareArea(2));
        }
        public static double SquareArea(double A)
        {
            double radius = (A * 4) / (2 * Math.PI);
            return Math.Round(Math.Pow(radius, 2), 2);
        }
    }
}
