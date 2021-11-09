/*
//  Author: Jonathan Scholl
//  Date: 11/9/2021
//  Project: Code Wars - 7th Kyu - Small enough?
//  Description: You will be given an array and a limit value. You must check that all values in the array are 
//  below or equal to the limit value. If they are, return true. Else, return false
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace Small_enough
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SmallEnough(new int[] {5, 6, 7, 8 }, 7));
        }
        public static bool SmallEnough(int[] a, int limit) => a.All(x => x <= limit) ? true : false;
    }
}
