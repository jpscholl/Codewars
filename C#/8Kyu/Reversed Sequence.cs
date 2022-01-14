/*
//  Author: Jonathan Scholl
//  Date: 1/14/2022
//  Project: https://www.codewars.com/kata/5a00e05cc374cb34d100000d
*/
using System;
using System.Collections.Generic;

namespace Reversed_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = ReverseSeq(5);

            foreach (int i in test)
            {
                Console.WriteLine(i);
            }
        }
        public static int[] ReverseSeq(int n)
        { 
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += i + 1;
            }

            Array.Reverse(arr);
            return arr;
        }
    }
}
