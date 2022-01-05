/*
//  Author: Jonathan Scholl
//  Date: 1/4/2022
//  Project: https://www.codewars.com/kata/52b5247074ea613a09000164/
*/
using System;

namespace Boiled_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CookingTime(1));
        }
        public static int CookingTime(int eggs)
        {
            // TODO
            int howManyAttempts = eggs / 8;
            int remainderEggs = eggs % 8;

            if (remainderEggs > 0) return (howManyAttempts * 5) + 5;
            return howManyAttempts * 5;
        }
    }
}
