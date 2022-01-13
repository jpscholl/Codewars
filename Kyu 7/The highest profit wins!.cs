/*
//  Author: Jonathan Scholl
//  Date: 1/13/2022
//  Project: https://www.codewars.com/kata/559590633066759614000063/
*/
using System;
using System.Linq;

namespace The_highest_profit_wins_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] { 1, 2, 5, -1, 12, 20 };

            int[] result = minMax(test);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
        public static int[] minMax(int[] lst)
        {
            // your code
            return new int[] {lst.Min(), lst.Max()};
        }
    }
}
