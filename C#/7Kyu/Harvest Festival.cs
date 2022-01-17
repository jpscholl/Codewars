/*
//  Author: Jonathan Scholl
//  Date: 1/17/2022
//  Project: https://www.codewars.com/kata/606efc6a9409580033837dfb
*/
using System;
using System.Linq;

namespace Harvest_Festival
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Plant('~', 1, 6, 30))
            {
                Console.Write(item);
            }
 
        }
        public static string Plant(char seed, int water, int fert, int temp)
        {
            string flower = string.Empty;
            string stemLength = string.Empty;
            string flowerCluster = string.Empty;

            if (temp > 19 && temp < 31)
            {
                //stem length
                for (int i = 0; i < water; i++)
                {
                    stemLength += '-';
                }
                //flowers clusters
                for (int i = 0; i < fert; i++)
                {
                    flowerCluster += $"{seed}";
                }
                //assemble final flower
                for (int i = 0; i < water; i++)
                {
                    flower += stemLength + flowerCluster;
                }
                //output flower
                return flower;
            }
            //returns dead plant
            return string.Concat(Enumerable.Repeat('-', (water * water))) + seed;
        }
    }
}
