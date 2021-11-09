/*
//  Author: Jonathan Scholl
//  Date: 11/9/2021
//  Project: Code Wars - Kyu 7 - Ones and Zeros
//  Description: Given an array of ones and zeroes, convert the equivalent binary value to an integer.
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace Ones_and_Zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[] { 0, 0, 1, 0 };


            foreach (var item in testArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine($"\nConverted: {binaryArrayToNumber(testArray)}");
        }

        public static int binaryArrayToNumber(int[] BinaryArray) => Convert.ToInt32(string.Join("", BinaryArray), 2);
        /*{
            //Code here
            string binaryIntToString = "";

            for (int x = 0; x < BinaryArray.Length; x++)
            {
                binaryIntToString += BinaryArray[x];
            }


            return Convert.ToInt32(binaryIntToString, 2);
        }*/
    }
}
