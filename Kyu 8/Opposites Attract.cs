/*
//  Author: Jonathan Scholl
//  Date: 12/17/2021
//  Project: https://www.codewars.com/kata/555086d53eac039a2a000083
*/
using System;

namespace Opposites_Attract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(lovefunc(1,4));
        }
        public static bool lovefunc(int flower1, int flower2)
        {
            //Moment of truth...
            //if modulo of both are equal then they are not in love
            return flower1 % 2 == flower2 % 2 ? false : true;
        }
    }
}
