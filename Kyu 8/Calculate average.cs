/*
//  Author: Jonathan Scholl
//  Date: 12/21/2021
//  Project: https://www.codewars.com/kata/57a2013acf1fa5bfc4000921
*/
using System;

namespace Calculate_average
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };
            Console.WriteLine(FindAverage(array));
        }
        public static double FindAverage(double[] array)
        {
            // Your code here
            
            if (array.Length == 0) return 0;
            double sum = 0, count = 0;

            for (int x = 0; x < array.Length; x++, count++)
            {
                sum += array[x];
            }

            return (double)sum / count;
        }
    }
}
