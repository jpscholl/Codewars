/*
//  Author: Jonathan Scholl
//  Date: 12/21/2021
//  Project: https://www.codewars.com/kata/570597e258b58f6edc00230d/train/csharp
*/
using System;

namespace Remove_First_and_Last_Characters_Part_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Array("2,34,234,1324"));
        }

        public static string Array(string s)
        {
            
            string result = null;
            string[] arr = s.Split(',');
            if (arr.Length > 2)
            {
                result = arr[1];
                for (int i = 2; i < arr.Length - 1; i++)
                {
                    result += " " + arr[i];
                }
            }

            return result;
        }
    }
}
