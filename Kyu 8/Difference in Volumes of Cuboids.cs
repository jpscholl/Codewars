/*
//  Author: Jonathan Scholl
//  Date: 12/21/2021
//  Project: https://www.codewars.com/kata/58cb43f4256836ed95000f97
*/
using System;

namespace Difference_in_Volumes_of_Cuboids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindDifference(new int[] { 3, 2, 5 }, new int[] { 1, 4, 4 }));
        }
        public static int FindDifference(int[] a, int[] b)
        {
            //loading...

            return Math.Abs(a[0] * a[1] * a[2] - b[0] * b[1] * b[2]);
        }
    }
}
