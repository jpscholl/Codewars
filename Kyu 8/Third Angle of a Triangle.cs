/*
//  Author: Jonathan Scholl
//  Date: 12/15/2021
//  Project: https://www.codewars.com/kata/5a023c426975981341000014
*/
using System;

namespace Third_Angle_of_a_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{OtherAngle(10, 10)}");
        }
        public static int OtherAngle(int a, int b)
        {
            return 180 - a - b;
        }
    }
}
