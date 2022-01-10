/*
//  Author: Jonathan Scholl
//  Date: 1/10/2022
//  Project: https://www.codewars.com/kata/562f91ff6a8b77dfe900006e
*/
using System;

namespace Going_to_the_cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Movie(500, 15, 0.9));
        }
        public static int Movie(int card, int ticket, double perc)
        {
            // your code
            int numOfTrips = 0;
            double costA = 0;
            double costB = card;

            while (Math.Ceiling(costB) >= costA)
            {
                costA += ticket;
                costB += ticket * Math.Pow(perc, ++numOfTrips);
            }
            return numOfTrips;
        }
    }
}
