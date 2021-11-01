/*
//  Author: Jonathan Scholl
//  Date: 11/1/2021
//  Project: Code Wars -- Sort array by sting length
//  Description: Write a function that takes an array of strings as an argument and 
//  returns a sorted array containing the same strings, ordered from shortest to longest.
*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace Sort_array_by_string_length
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testArray = new string[] { "Beg", "Life", "I", "To" };

            SortByLength(testArray);

            foreach (var item in testArray)
            {
                Console.WriteLine(item);
            }

        }
        public static string[] SortByLength(string[] arr)
        {
            List<string> convertArrayToList = arr.ToList();

            convertArrayToList.Sort((x, y) => x.Length.CompareTo(y.Length));

            return convertArrayToList.ToArray<string>();
        }
    }
}
