/*
//  Author: Jonathan Scholl
//  Date: 12/22/2021
//  Project: https://www.codewars.com/kata/57cff961eca260b71900008f
*/
using System;

namespace Is_there_a_vowel_in_there
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsVow(new object[] { 118, 117, 120, 121, 117, 98, 122, 97, 120, 106, 104, 116, 113, 114, 113, 120, 106 }));
        }
        public static object[] IsVow(object[] a)
        {
            for (int x = 0; x < a.Length; x++)
            {
                if (a[x].Equals(97)) a[x] = "a";
                if (a[x].Equals(101)) a[x] = "e";
                if (a[x].Equals(105)) a[x] = "i";
                if (a[x].Equals(111)) a[x] = "o";
                if (a[x].Equals(117)) a[x] = "u";
            }
            return a;
        }
    }
}
