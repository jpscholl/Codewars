/*
//  Author: Jonathan Scholl
//  Date: 1/13/2022
//  Project: https://www.codewars.com/kata/57bfea4cb19505912900012c
*/
using System;

namespace Points_of_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = SymmetricPoint(new int[] { 0, 0 }, new int[] { 1, 1 });

            foreach (int i in test)
            {
                Console.WriteLine(i);
            }
        }
        public static int[] SymmetricPoint(int[] p, int[] q)
        {
            int[] output = new int[] { 2 * q[0] - p[0], 2 * q[1] - p[1] };
            return output;
        }
    }
}
