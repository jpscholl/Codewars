/*
//  Author: Jonathan Scholl
//  Date: 12/21/2021
//  Project: https://www.codewars.com/kata/59ca8246d751df55cc00014c
*/
using System;

namespace Is_he_gonna_survive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Will the hero live: {Hero(11, 6)}");
        }
        public static bool Hero(int bullets, int dragons)
        {
            //Do Some Magic...
            return bullets / 2 >= dragons;
        }
    }
}
