/*
//  Author: Jonathan Scholl
//  Date: 12/21/2021
//  Project: https://www.codewars.com/kata/55cb632c1a5d7b3ad0000145/train/csharp
*/
using System;

namespace Keep_up_the_hoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HoopCount(5));
            Console.WriteLine(HoopCount(13));
        }

        public static string HoopCount(int n)
        {
            //Your code goes here
            if (n >= 10)
            {
                return "Great, now move on to tricks";
            } 
            else
            {
                return "Keep at it until you get it";
            }
            
            //alternative
            //return n >= 10 ? "Great, now move on to tricks" : "Keep at it until you get it";
        }
    }
}
