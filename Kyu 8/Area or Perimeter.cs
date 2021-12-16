/*
//  Author: Jonathan Scholl
//  Date: 12/15/2021
//  Project: https://www.codewars.com/kata/5ab6538b379d20ad880000ab
*/
using System;

namespace Area_or_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreaOrPerimeter(6, 10));
        }
        public static int AreaOrPerimeter(int l, int w)
        {
            // code goes here

            if (l == w)
            {
                return l * w;
            }

            return 2 * (l + w);
        }
    }
}
