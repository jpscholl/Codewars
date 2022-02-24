/*
//  Author: Jonathan Scholl
//  Date: 2/23/2022
//  Project: https://www.codewars.com/kata/559f3123e66a7204f000009f
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace Take_an_Arrow_to_the_knee__Functionally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArrowFunc(new int[] { 84, 101, 115, 116 }));
        }
        public static string ArrowFunc(int[] arr) => string.Join("", arr.Select(x => Convert.ToChar(x)).ToArray());

    }
}
