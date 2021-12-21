/*
//  Author: Jonathan Scholl
//  Date: 12/21/2021
//  Project: https://www.codewars.com/kata/59a1cdde9f922b83ee00003b
*/
using System;
using System.Linq;

namespace Stanton_measure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StantonMeasure(new int[] { 1, 4, 3, 2, 1, 2, 3, 2 }));
        }

        public static int StantonMeasure(int[] arr)
        {
            //The code begins..
            int onesCounter = 0;
            int StantonCounter = 0;

            for (int x = 0; x < arr.Length; x++)
            {
                if (arr[x] == 1) onesCounter++;
            } 

            for (int x = 0; x < arr.Length; x++)
            {
                if (arr[x] == onesCounter) StantonCounter++;
            }

            return StantonCounter;
        }
    }
}
