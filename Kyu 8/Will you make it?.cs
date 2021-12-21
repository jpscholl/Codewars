/*
//  Author: Jonathan Scholl
//  Date: 12/21/2021
//  Project: https://www.codewars.com/kata/5861d28f124b35723e00005e
*/
using System;

namespace Will_you_make_it
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Will you make it to the gas station: {ZeroFuel(100, 25, 2)}");
        }

        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            return distanceToPump <= mpg * fuelLeft;
        }
    }
}
