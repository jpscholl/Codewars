/*
//  Author: Jonathan Scholl
//  Date: 1/17/2022
//  Project: https://www.codewars.com/kata/5b077ebdaf15be5c7f000077
*/
using System;

namespace If_you_can_t_sleep__just_count_sheep__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountSheep(3));
        }
        public static string CountSheep(int n)
        {
            string result = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                result += $"{i} sheep...";
            }

            return result;
        }
    }
}
