/*
//  Author: Jonathan Scholl
//  Date: 12/22/2021
//  Project: https://www.codewars.com/kata/5a2be17aee1aaefe2a000151
*/
using System;

namespace Array_plus_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArrayPlusArray(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }));
        }
        public static int ArrayPlusArray(int[] arr1, int[] arr2)
        {
            int sumOfTwoArrays = 0;

            for (int x = 0; x < arr1.Length; x++)
            {
                sumOfTwoArrays += arr1[x];
            }

            for (int x = 0; x < arr2.Length; x++)
            {
                sumOfTwoArrays += arr2[x];
            }

            return sumOfTwoArrays;
        }
    }
}
