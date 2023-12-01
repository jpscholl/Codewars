/*
//  Author: Jonathan Scholl
//  Date: 12/1/2023
//  Project: https://www.codewars.com/kata/53dc54212259ed3d4f00071c/train/csharp
*/
using System;
using System.Linq;

namespace SumArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] testData = { 1, 5.2, 4, 0, -1 };

            Console.WriteLine(SumArray(testData));
        }
        public static double SumArray(double[] array)
        {
            if (array == null) 
            { 
                return 0; 
            }
            else
            {
                return array.Sum();
            }
        }
    }
}
