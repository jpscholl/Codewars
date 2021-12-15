/*
//  Author: Jonathan Scholl
//  Date: 12/14/2021
//  Project: https://www.codewars.com/kata/568d0dd208ee69389d000016
*/
using System;

namespace Transportation_on_vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input days: ");
            int days = int.Parse(Console.ReadLine());

            Console.WriteLine($"{days} = {RentalCarCost(days)}");
        }

        public static int RentalCarCost(int d)
        {
            // your code
            int totalRent = 0;

            if (d >= 7) totalRent = 40 * d - 50;
            else if (d >= 3) totalRent = 40 * d - 20;
            else totalRent = 40 * d;

            return totalRent;
        }
    }
}
